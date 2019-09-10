using Senai.OpFlix.WebApi.Domains;
using Senai.OpFlix.WebApi.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Senai.OpFlix.WebApi.Repositories
{
    public class LancamentosRepository : ILancamentosRepository
    {
        public void Atualizar(Lancamentos lancamento)
        {
            throw new NotImplementedException();
        }

        public Lancamentos BuscarPorId(int id)
        {
            throw new NotImplementedException();
        }

        public void Cadastrar(Lancamentos lancamento)
        {
            using (opflixContext ctx = new opflixContext())
            {
                ctx.Lancamentos.Add(lancamento);
                ctx.SaveChanges();
            }
        }

        public void Deletar(int id)
        {
            using(opflixContext ctx = new opflixContext())
            {
                Lancamentos Lancamento = ctx.Lancamentos.Find(id);
                ctx.Lancamentos.Remove(Lancamento);
                ctx.SaveChanges(); 
            }
        }

        public List<Lancamentos> Listar()
        {
            using(opflixContext ctx = new opflixContext())
            {
                return ctx.Lancamentos.ToList();
            }
        }
    }
}
