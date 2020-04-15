using Microsoft.AspNetCore.Mvc;
using Services.DTOs;
using Services.Services.Interfaces;
using System;
using System.Collections.Generic;

namespace App.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsuarioController : ControllerBase
    {
        private readonly IUsuarioService _usuarioService;

        public UsuarioController(IUsuarioService usuarioService)
        {
            _usuarioService = usuarioService;
        }
        [HttpGet]
        public ActionResult<List<UsuarioDTO>> GetAll()
        {
            return Ok(_usuarioService.GetAll());
        }

        [HttpGet("{id}")]
        public ActionResult<UsuarioDTO> GetById(Guid id)
        {
            var usuario = _usuarioService.Get(id);
            return Ok(usuario);
        }
        [HttpPost]
        public ActionResult Post([FromBody] CreateUsuarioDTO createUsuarioDTO)
        {
            try
            {
                _usuarioService.Save(createUsuarioDTO);
                return Ok();
            }
            catch (Exception e)
            {
                string errors = e.Message;
                return ValidationProblem(new ValidationProblemDetails()
                {
                    Type = "Model Validation Error",
                    Detail = errors
                });
            }
        }
        [HttpPut]
        public ActionResult Put([FromBody] UpdateUsuarioDTO updateUsuarioDTO)
        {
            try
            {
                _usuarioService.Update(updateUsuarioDTO);
                return Ok();
            }
            catch (Exception e)
            {
                string errors = e.Message;
                return ValidationProblem(new ValidationProblemDetails()
                {
                    Type = "Model Validation Error",
                    Detail = errors
                });
            }
        }
        [HttpDelete("{id}")]
        public ActionResult Delete(Guid id)
        {
            try
            {
                _usuarioService.Delete(id);
                return Ok();
            }
            catch (Exception e)
            {
                string errors = e.Message;
                return ValidationProblem(new ValidationProblemDetails()
                {
                    Type = "Cannot delete",
                    Detail = errors
                });
            }
        }
    }
}
