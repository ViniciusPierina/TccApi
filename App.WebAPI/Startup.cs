using AutoMapper;
using Core.CQRS;
using Domain.Commands;
using Domain.Handlers.Commands;
using Domain.Interfaces;
using Domain.Models;
using Infrastructure.Bus;
using Infrastructure.Configurations;
using Infrastructure.Repositories;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.IdentityModel.Tokens;
using Microsoft.OpenApi.Models;
using Newtonsoft.Json;
using Services;
using Services.Mappings;
using Services.Services;
using Services.Services.Interfaces;
using System.Text;

namespace App.WebAPI
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddCors();
            services.AddControllers();

            services.AddScoped<IGuiaService, GuiaService>();
            services.AddScoped<IAgendamentoService, AgendamentoService>();
            services.AddScoped<IContratoService, ContratoService>();
            services.AddScoped<IMedicoService, MedicoService>();
            services.AddScoped<IUsuarioService, UsuarioService>();
            services.AddScoped<IEspecialidadeService, EspecialidadeService>();

            services.AddScoped<IRepository<Guia>, GuiaRepository>();
            services.AddScoped<IRepository<Agendamento>, AgendamentoRepository>();
            services.AddScoped<IRepository<Contrato>, ContratoRepository>();
            services.AddScoped<IRepository<Medico>, MedicoRepository>();
            services.AddScoped<IRepository<Usuario>, UsuarioRepository>();
            services.AddScoped<IRepository<Especialidade>, EspecialidadeRepository>();
            services.AddScoped<ILoginRepository, LoginRepository>();

            services.AddScoped<IHandler<CreateGuiaCommand>, GuiaCommandHandler>();
            services.AddScoped<IHandler<UpdateGuiaCommand>, GuiaCommandHandler>();
            services.AddScoped<IHandler<RemoveGuiaCommand>, GuiaCommandHandler>();

            services.AddScoped<IHandler<CreateAgendamentoCommand>, AgendamentoCommandHandler>();
            services.AddScoped<IHandler<UpdateAgendamentoCommand>, AgendamentoCommandHandler>();
            services.AddScoped<IHandler<RemoveAgendamentoCommand>, AgendamentoCommandHandler>();

            services.AddScoped<IHandler<CreateContratoCommand>, ContratoCommandHandler>();
            services.AddScoped<IHandler<UpdateContratoCommand>, ContratoCommandHandler>();
            services.AddScoped<IHandler<RemoveContratoCommand>, ContratoCommandHandler>();

            services.AddScoped<IHandler<CreateMedicoCommand>, MedicoCommandHandler>();
            services.AddScoped<IHandler<UpdateMedicoCommand>, MedicoCommandHandler>();
            services.AddScoped<IHandler<RemoveMedicoCommand>, MedicoCommandHandler>();

            services.AddScoped<IHandler<CreateUsuarioCommand>, UsuarioCommandHandler>();
            services.AddScoped<IHandler<UpdateUsuarioCommand>, UsuarioCommandHandler>();
            services.AddScoped<IHandler<RemoveUsuarioCommand>, UsuarioCommandHandler>();

            services.AddScoped<IHandler<CreateEspecialidadeCommand>, EspecialidadeCommandHandler>();
            services.AddScoped<IHandler<UpdateEspecialidadeCommand>, EspecialidadeCommandHandler>();
            services.AddScoped<IHandler<RemoveEspecialidadeCommand>, EspecialidadeCommandHandler>();

            services.AddSingleton<IHttpContextAccessor, HttpContextAccessor>();

            services.AddScoped<IBus, InMemoryBus>();

            ConfigureAutomapper(services);

            ConfigureSwagger(services);

            services.AddDbContext<ConfigurationContext>(options => options.UseSqlServer(Configuration["ConnectionStrings:DefaultConnection"]));

            services
                .AddMvc()
                .SetCompatibilityVersion(CompatibilityVersion.Version_3_0)
                .AddNewtonsoftJson(options =>
                {
                    options.SerializerSettings.ReferenceLoopHandling = ReferenceLoopHandling.Ignore;
                });

            services.AddRazorPages();

            var key = Encoding.ASCII.GetBytes(Settings.Secret);
            services.AddAuthentication(x =>
            {
                x.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
                x.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
            })
            .AddJwtBearer(x =>
            {
                x.RequireHttpsMetadata = false;
                x.SaveToken = true;
                x.TokenValidationParameters = new TokenValidationParameters
                {
                    ValidateIssuerSigningKey = true,
                    IssuerSigningKey = new SymmetricSecurityKey(key),
                    ValidateIssuer = false,
                    ValidateAudience = false
                };
            });


        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            ConfigureSwaggerUi(app);

            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseCors(x => x
                .AllowAnyOrigin()
                .AllowAnyMethod()
                .AllowAnyHeader());

            app.UseAuthentication();
            app.UseAuthorization();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });

        }

        private static void ConfigureAutomapper(IServiceCollection services)
        {
            var mappingConfig = new MapperConfiguration(mc =>
            {
                mc.AddProfile(new MappingProfiles());
            });

            IMapper mapper = mappingConfig.CreateMapper();
            services.AddSingleton(mapper);
        }

        private static void ConfigureSwagger(IServiceCollection services)
        {
            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo { Title = "TCC API", Version = "v1" });
            });
        }

        private static void ConfigureSwaggerUi(IApplicationBuilder app)
        {
            app.UseSwagger();

            app.UseSwaggerUI(c =>
            {
                c.SwaggerEndpoint("/swagger/v1/swagger.json", "TCC");
                c.RoutePrefix = string.Empty;
            });
        }
    }
}
