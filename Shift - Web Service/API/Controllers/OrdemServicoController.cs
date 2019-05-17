using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Teste.Domain.Entities;
using Teste.Service.Services;
using Teste.Service.Validators;

namespace API.Controllers
{
    [Produces("application/json")]
    [Route("api/[controller]")]
    [ApiController]
    public class OrdemServicoController : ControllerBase
    {

        private OrdemServicoService _service = new OrdemServicoService();

        [HttpPost]
        public IActionResult Post([FromBody] OrdemServico model)
        {
            try
            {
                _service.Post<OrdemServicoValidator>(model);

                return new ObjectResult(model.Id);
            }
            catch (ArgumentNullException ex)
            {
                return NotFound(ex);
            }
            catch (Exception ex)
            {
                return BadRequest(ex);
            }
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            try
            {
                _service.Remove(id);

                return new NoContentResult();
            }
            catch (ArgumentException ex)
            {
                return NotFound(ex);
            }
            catch (Exception ex)
            {
                return BadRequest(ex);
            }
        }

        [HttpGet]
        public IActionResult Get()
        {
            try
            {
                var res = _service.Get("Paciente");
                return new ObjectResult(res.Select(os => {
                    os.Paciente.OrdensServico = null;
                    return os;
                }).OrderByDescending(os => os.Id));
            }
            catch (Exception ex)
            {
                return BadRequest(ex);
            }
        }

        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            try
            {
                var res = _service.Get(id, "Exames", "Exames.Exame", "Convenio", "Paciente", "Medico", "PostoColeta");
                res.Convenio.OrdensServico = null;
                res.Convenio.PrecoExames = null;
                res.Medico.OrdensServico = null;
                res.Medico.Especialidade = null;
                res.Paciente.OrdensServico = null;
                res.Paciente.Cidade = null;
                res.PostoColeta.OrdensServico = null;
                res.Exames = res.Exames.Select(e =>
                {
                    e.OrdemServico = null;
                    e.Exame.OrdemServicoExames = null;
                    e.DataEntrega = res.Data.Value.AddDays(e.Exame.Prazo);
                    return e;
                }).OrderBy(e => e.DataEntrega).ThenBy(e => e.EntregaResultado);

                return new ObjectResult(res);
            }
            catch (ArgumentException ex)
            {
                return NotFound(ex);
            }
            catch (Exception ex)
            {
                return BadRequest(ex);
            }
        }

    }
}