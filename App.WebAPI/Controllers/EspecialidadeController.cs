using Microsoft.AspNetCore.Mvc;
using Services.DTOs;
using Services.Services.Interfaces;
using System;
using System.Collections.Generic;

namespace App.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EspecialidadeController : ControllerBase
    {
        private readonly IEspecialidadeService _especialidadeService;

        public EspecialidadeController(IEspecialidadeService especialidadeService)
        {
            _especialidadeService = especialidadeService;
        }

        [HttpGet]
        public ActionResult<List<EspecialidadeDTO>> GetAll()
        {
            return Ok(_especialidadeService.GetAll());
        }

        [HttpGet("{id}")]
        public ActionResult<EspecialidadeDTO> GetById(Guid id)
        {
            var especialidade = _especialidadeService.Get(id);
            return Ok(especialidade);
        }

        [HttpPost]
        public ActionResult Post([FromBody] CreateEspecialidadeDTO createEspecialidadeDTO)
        {
            try
            {
                _especialidadeService.Save(createEspecialidadeDTO);
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
        public ActionResult Put([FromBody] UpdateEspecialidadeDTO updateEspecialidadeDTO)
        {
            try
            {
                _especialidadeService.Update(updateEspecialidadeDTO);
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
                _especialidadeService.Delete(id);
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
