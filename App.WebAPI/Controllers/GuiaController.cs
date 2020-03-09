using Microsoft.AspNetCore.Mvc;
using Services.DTOs;
using Services.Services.Interfaces;
using System;
using System.Collections.Generic;

namespace App.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GuiaController : ControllerBase
    {
        private readonly IGuiaService _guiaService;

        public GuiaController(IGuiaService guiaService)
        {
            _guiaService = guiaService;
        }

        [HttpGet]
        public ActionResult<List<GuiaDTO>> GetAll()
        {
            return Ok(_guiaService.GetAll());
        }

        [HttpGet("{id}")]
        public ActionResult<GuiaDTO> GetById(Guid id)
        {
            var guia = _guiaService.Get(id);
            return Ok(guia);
        }

        [HttpPost]
        public ActionResult Post([FromBody] CreateGuiaDTO createGuiaDTO)
        {
            try
            {
                _guiaService.Save(createGuiaDTO);
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
        public ActionResult Put([FromBody] UpdateGuiaDTO updateGuiaDTO)
        {
            try
            {
                _guiaService.Update(updateGuiaDTO);
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
                _guiaService.Delete(id);
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
