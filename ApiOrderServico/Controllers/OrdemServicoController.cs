using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace ApiOrderServico.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class OrdemServicoController : ControllerBase
    {
        [HttpGet("{ordemServicoId}")]
        public IActionResult GetStatus(Guid ordemServicoId){

            return Ok();
        }

        [HttpPost]
        public IActionResult CreateOrdemServico(){

            return Ok();
        }

        [HttpPost("/FinalizarOrdemServico/{operadorFechamentoId}")]
        public IActionResult FinalizarOrdemServico(int operadorFechamentoId){

            return Ok();
        }

        [HttpPost("/AnalisarOrdem/{operadorAnaliseId}")]
        public IActionResult AnalisarOrdem(Guid operadorAnaliseId){

            return Ok();
        }
    }
}