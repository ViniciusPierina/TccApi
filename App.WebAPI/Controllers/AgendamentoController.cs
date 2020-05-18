using Microsoft.AspNetCore.Mvc;
using Services.DTOs;
using Services.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace App.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AgendamentoController : ControllerBase
    {
        private readonly IAgendamentoService _agendamentoService;

        public AgendamentoController(IAgendamentoService agendamentoService)
        {
            _agendamentoService = agendamentoService;
        }

        [HttpGet]
        public ActionResult<List<AgendamentoDTO>> GetAll()
        {
            return Ok(_agendamentoService.GetAll());
        }

        [HttpGet("{id}")]
        public ActionResult<AgendamentoDTO> GetById(Guid id)
        {
            var agendamento = _agendamentoService.Get(id);
            return Ok(agendamento);
        }

        [HttpPost]
        public ActionResult Post([FromBody] CreateAgendamentoDTO createAgendamentoDTO)
        {
            try
            {
                _agendamentoService.Save(createAgendamentoDTO);
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
        public ActionResult Put([FromBody] UpdateAgendamentoDTO updateAgendamentoDTO)
        {
            try
            {
                _agendamentoService.Update(updateAgendamentoDTO);
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
                _agendamentoService.Delete(id);
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
