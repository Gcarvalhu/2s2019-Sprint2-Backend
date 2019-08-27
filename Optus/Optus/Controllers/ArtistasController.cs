using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Optus.Domains;
using Optus.Repositories;

namespace Optus.Controllers
{
    [Route("api/[controller]")]
    [Produces("application/json")]
    [ApiController]
    public class ArtistasController : ControllerBase
    {
        ArtistasRepository ArtistasRepository = new ArtistasRepository();

        [HttpGet]
        public IActionResult Listar()
        {
            return Ok(ArtistasRepository.Listar());
        }
        [HttpPost]
        public IActionResult Cadastrar(Artistas artista)
        {
            try
            {
                ArtistasRepository.Cadastrar(artista);
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(new { mensagem = "ERRRRRROOOOOU" + ex.Message });
            }
        }
    }
}