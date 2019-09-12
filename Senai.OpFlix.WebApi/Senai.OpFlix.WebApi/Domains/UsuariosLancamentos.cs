using System;
using System.Collections.Generic;

namespace Senai.OpFlix.WebApi.Domains
{
    public partial class UsuariosLancamentos
    {
        public int IdPrincipal { get; set; }
        public int? IdUsuario { get; set; }
        public int? IdLanc { get; set; }

        public Lancamentos IdLancNavigation { get; set; }
        public Usuarios IdUsuarioNavigation { get; set; }
    }
}
