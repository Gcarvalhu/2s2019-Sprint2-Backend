using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Senai.Ekips.WebApi.Domains;
using Senai.Ekips.WebApi.Repositories;

namespace Senai.Ekips.WebApi.Controllers
{
    [Route("api/[controller]")]
    [Produces("application/json")]
    [ApiController]
    public class FuncionariosController : ControllerBase
    {
        FuncionarioRepository FuncionarioRepository = new FuncionarioRepository();
        [HttpGet]
        public IActionResult Listar()
        {
            return Ok(FuncionarioRepository.Listar());
        }
        [HttpPost]
        public IActionResult Cadastrar(Funcionarios funcionarios)
        {
            try
            {
                FuncionarioRepository.Cadastrar(funcionarios);
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(new { mensagem = "IH GARAI DEU ERRO" + ex.Message });
            }
        }
        [HttpPut]
        public IActionResult Atualizar(Funcionarios funcionarios)
        {
            try
            {
                Funcionarios FuncionarioBuscado = FuncionarioRepository.BuscarPorId(funcionarios.IdFuncionario);
                if (FuncionarioBuscado == null)
                    return NotFound();

                FuncionarioRepository.Atualizar(funcionarios);
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(new { mensagem = "AH NAO VEI DEU ERRO DENOVO" + ex.Message });
            }
        }
        [HttpDelete("{id}")
            ]
        public IActionResult Deletar(int id)
        {
            FuncionarioRepository.Deletar(id);
            return Ok();
        }
    }
}