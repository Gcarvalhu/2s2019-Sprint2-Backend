using Senai.Filmes.WebApi.Domains;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Senai.Filmes.WebApi.Repository
{
    public class GeneroRepository
    {
        // aonde que será feita essa comunicação
        // private string StringConexao = "Data Source=.\\SqlExpress;Initial Catalog=T_SStop;User Id=sa;Pwd=132;";
        private string StringConexao = "Data Source=localhost;Initial Catalog=RoteiroFilmes;Integrated Security=true;";
        public List<GeneroDomain> ListarTodos()
        {
           List<GeneroDomain> generos = new List<GeneroDomain>();
            return generos;
        }

    }
}
