using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Teste.Domain.Entities;
using Teste.Service.Services;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ConvenioController : ControllerBase
    {
        private BaseService<Convenio> _service = new BaseService<Convenio>();

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