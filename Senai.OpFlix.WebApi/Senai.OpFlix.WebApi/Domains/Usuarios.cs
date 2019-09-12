using System;
using System.Collections.Generic;

namespace Senai.OpFlix.WebApi.Domains
{
    public partial class Usuarios
    {
        public Usuarios()
        {
            UsuariosLancamentos = new HashSet<UsuariosLancamentos>();
        }

        public int IdUsuario { get; set; }
        public string Email { get; set; }
        public string Senha { get; set; }
        public string Permissao { get; set; }
        public string Nome { get; set; }

        public ICollection<UsuariosLancamentos> UsuariosLancamentos { get; set; }
    }
}
