using Domain.Interfaces;
using Domain.Models;
using Infrastructure.Repositories;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Services.Services;
using System;
using System.Threading.Tasks;

namespace App.WebAPI.Controllers
{
    [Route("api/[controller]")]
	[ApiController]
	public class HomeController : ControllerBase
	{
        private readonly ILoginRepository _repository;

        public HomeController(ILoginRepository repository)
        {
            _repository = repository;
        }

        [HttpPost]
        [Route("login")]
        [AllowAnonymous]
        public async Task<ActionResult<dynamic>> Authenticate([FromBody]Usuario model)
        {
            var user = _repository.GetUsuarioLogin(model.Email, model.Cpf);

            if (user == null)
                return NotFound(new { message = "Usuário ou senha inválidos" });

            var token = TokenService.GenerateUsuarioToken(user);
            user.Cpf = "";
            return new
            {
                user = user,
                token = token
            };
        }

        [HttpPost]
        [Route("loginMedico")]
        [AllowAnonymous]
        public async Task<ActionResult<dynamic>> AuthenticateMedico([FromBody]Medico model)
        {
            var user = _repository.GetMedicoLogin(model.Conselho, model.Crmprest);

            if (user == null)
                return NotFound(new { message = "Conselho ou CRM inválidos" });

            var token = TokenService.GenerateMedicoToken(user);
            user.Crmprest = "";
            return new
            {
                user = user,
                token = token
            };
        }

        [HttpGet]
        [Route("anonymous")]
        [AllowAnonymous]
        public string Anonymous() => "Anônimo";

        [HttpGet]
        [Route("authenticated")]
        [Authorize]
        public string Authenticated() => String.Format("Autenticado - {0}", User.Identity.Name);
    }
}
