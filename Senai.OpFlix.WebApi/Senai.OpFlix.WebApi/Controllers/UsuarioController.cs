using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Senai.OpFlix.WebApi.Domains;
using Senai.OpFlix.WebApi.Interfaces;
using Senai.OpFlix.WebApi.Repositories;

namespace Senai.OpFlix.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsuarioController : ControllerBase
    {
        IUsuarioRepository UsuarioRepository { get; set; }

        public UsuarioController()
        {
            UsuarioRepository = new UsuarioRepository();
        }

        [HttpGet]
        public IActionResult Listar()
        {
            return Ok(UsuarioRepository.Listar());
        }
        [HttpPost]
        public IActionResult Atualizar(Usuarios usuario)
        {
            try
            {

                Usuarios UsuarioBuscado = UsuarioRepository.BuscarPorId(usuario.IdUsuario);

                if (UsuarioBuscado == null)
                    return NotFound();

                UsuarioRepository.Atualizar(usuario);
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(new { mensagem = "ERRO" });
            }
        }

        [HttpGet]
        public IActionResult BuscarPorId (int id)
        {
            try
            {
                Usuarios usuario = UsuarioRepository.BuscarPorId(id);
                if (usuario == null)
                    return NotFound();
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(new { mensagem = ex.Message });
            }
        }
        [HttpPost]
        public IActionResult Cadastrar (Usuarios usuario)
        {
            UsuarioRepository.Cadastrar(usuario);
            return Ok();
        }
        [HttpDelete("{id}")]
        public IActionResult Deletar (int id)
        {
            UsuarioRepository.Deletar(id);
            return Ok();
        } 
    }
}