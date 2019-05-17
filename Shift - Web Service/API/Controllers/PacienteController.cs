using System;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Teste.Service.Services;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PacienteController : ControllerBase
    {

        private PacienteService _service = new PacienteService();

        [HttpGet]
        public IActionResult Get()
        {
            try
            {
                return new ObjectResult(_service.Get().OrderBy(p => p.Nome));
            }
            catch (Exception ex)
            {
                return BadRequest(ex);
            }
        }

    }
}