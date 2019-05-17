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
    public class PostoColetaController : ControllerBase
    {
        private BaseService<PostoColeta> _service = new BaseService<PostoColeta>();

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