﻿using Optus.Domains;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Optus.Repositories
{
    public class ArtistasRepository
    {
        public List<Artistas> Listar()
        {
            using (OptusContext ctx = new OptusContext())
            {
                return ctx.Artistas.ToList();
            }
        }
        public void Cadastrar (Artistas artista)
        {
            using(OptusContext ctx = new OptusContext())
            {
                ctx.Artistas.Add(artista);
                ctx.SaveChanges();
            }
        }
    }
}
