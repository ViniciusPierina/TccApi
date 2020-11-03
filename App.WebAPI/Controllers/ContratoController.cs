using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Services.DTOs;
using Services.Services.Interfaces;
using System;
using System.Collections.Generic;

namespace App.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ContratoController : ControllerBase
    {
        private readonly IContratoService _contratoService;

        public ContratoController(IContratoService contratoService)
        {
            _contratoService = contratoService;
        }

        [HttpGet]
        public ActionResult<List<ContratoDTO>> GetAll()
        {
            return Ok(_contratoService.GetAll());
        }

        [HttpGet("{id}")]
        [Authorize]
        public ActionResult<ContratoDTO> GetById(Guid id)
        {
            var contrato = _contratoService.Get(id);
            return Ok(contrato);
        }

        [HttpPost]
        public ActionResult Post([FromBody] CreateContratoDTO createContratoDTO)
        {
            try
            {
                _contratoService.Save(createContratoDTO);
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
        public ActionResult Put([FromBody] UpdateContratoDTO updateContratoDTO)
        {
            try
            {
                _contratoService.Update(updateContratoDTO);
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
                _contratoService.Delete(id);
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