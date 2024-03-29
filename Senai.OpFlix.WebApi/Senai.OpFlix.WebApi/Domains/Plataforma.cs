﻿using System;
using System.Collections.Generic;

namespace Senai.OpFlix.WebApi.Domains
{
    public partial class Plataforma
    {
        public Plataforma()
        {
            Lancamentos = new HashSet<Lancamentos>();
        }

        public int IdPlataforma { get; set; }
        public string NomePlataforma { get; set; }

        public ICollection<Lancamentos> Lancamentos { get; set; }
    }
}
