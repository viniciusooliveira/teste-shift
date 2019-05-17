using System;
using Microsoft.AspNetCore.Mvc;
using Teste.Domain.Entities;
using Teste.Service.Services;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ExameController : ControllerBase
    {

        private BaseService<Exame> _service = new BaseService<Exame>();

        [HttpGet]
        public IActionResult Get()
        {
            try
            {
                return new ObjectResult(_service.Get());
            }
            catch (Exception ex)
            {
                return BadRequest(ex);
            }
        }

    }
}