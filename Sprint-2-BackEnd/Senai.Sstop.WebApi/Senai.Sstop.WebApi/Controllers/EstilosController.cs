using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Senai.Sstop.WebApi.Domains;
using Senai.Sstop.WebApi.Repositories;

namespace Senai.Sstop.WebApi.Controllers
{
    [Route("api/[controller]")]
    [Produces("application/json")]
    [ApiController]
    public class EstilosController : ControllerBase
    {

        EstiloRepository EstiloRepository = new EstiloRepository();

        [HttpGet]
        public IEnumerable<EstiloDomain> ListarTodos()
        {
            return EstiloRepository.Listar();
        }

        // o controller devera receber o id que eu quero buscar
        // GET /api/estilos/3
        [HttpGet("{id}")]
        public IActionResult BuscarPorId(int id)
        {
            EstiloDomain estiloDomain = EstiloRepository.BuscarPorId(id);
            if (estiloDomain == null)
                return NotFound();
            return Ok(estiloDomain);
        }
        [HttpDelete("{id}")]
        public IActionResult Deletar (int id)
        {
            EstiloRepository.Deletar(id);
            return Ok();
        }
    }
}
