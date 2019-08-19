using Microsoft.AspNetCore.Mvc;
using Senai.Sstop.WebApi.Domains;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace Senai.Sstop.WebApi.Repository
{
    public class EstiloRepository
    {
        private string StringConexao = "Data Source.\\SqlExpress;Initial Catalog=T_SStop;User Id=sa;Pwd=132";
        public List<EstiloDomain> Listar()
        {
            List<EstiloDomain> estilos = new List<EstiloDomain>();

            //chamar o banco
            using (SqlConnection con = new SqlConnection(StringConexao))
            {
                //nossa query a ser selecionada
                string Query = "SELECT IdEstiloMusical,Nome FROM EstilosMusicais";
                //Abrir a conexao
                con.Open();

                //Declaro para percorrer a lista
                SqlDataReader sdr;

                using (SqlCommand cmd = new SqlCommand(Query, con))
                {
                    //pegar os valores da tabela do banco de dados e armazenar dentro da aplicação backend
                    sdr = cmd.ExecuteReader();

                    while (sdr.Read())
                    {
                        EstiloDomain estilo = new EstiloDomain
                        {
                            IdEstilo = Convert.ToInt32(sdr["IdEstiloMusical"]),
                            Nome = sdr["Nome"].ToString()
                        };
                        estilos.Add(estilo);
                    }
                }

            }
                //fazer o select
                //retornar as informaçoes

                return estilos;
        }
        
            List<EstiloDomain> estilos = new List<EstiloDomain>
        {
            new EstiloDomain { IdEstilo = 1, Nome = "Rock" },
            new EstiloDomain { IdEstilo = 2, Nome = "Pop" },
            new EstiloDomain { IdEstilo = 3, Nome = "Folk" }
        };

        EstiloRepository estiloRepository = new EstiloRepository(); 

            [HttpGet]
            public IEnumerable<EstiloDomain> ListarTodos()
            {
            return estiloRepository.Listar();
            }

            [HttpGet("{id}")]
            public IActionResult BuscarPorId(int id)
            {
                EstiloDomain Estilo = estilos.Find(x => x.IdEstilo == id);
                if (Estilo == null)
                {
                    return NotFound();
                }
                return Ok(Estilo);
            }

        private IActionResult Ok(EstiloDomain estilo)
        {
            throw new NotImplementedException();
        }

        private IActionResult NotFound()
        {
            throw new NotImplementedException();
        }

        [HttpPost]
            public IActionResult Cadastrar(EstiloDomain estiloDomain)
            {
                estilos.Add(
                    new EstiloDomain
                    {
                        IdEstilo = estilos.Count + 1,
                        Nome = estiloDomain.Nome
                    }
                );
                return Ok(estilos);
            }

        private IActionResult Ok(List<EstiloDomain> estilos)
        {
            throw new NotImplementedException();
        }
    }
    }

