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
    public class PrecoExameController : ControllerBase
    {

        private BaseService<PrecoExame> _service = new BaseService<PrecoExame>();

        [HttpGet]
        public IActionResult Get(int idExame, int idConvenio)
        {
            try
            {
                var preco = _service.GetWhere(p => p.IdConvenio == idConvenio && p.IdExame == idExame).FirstOrDefault();
                return new ObjectResult(new {
                    preco = preco.Preco.ToString("N"),
                    id = preco.Id
                });
            }
            catch (Exception ex)
            {
                return BadRequest(ex);
            }
        }

    }
}