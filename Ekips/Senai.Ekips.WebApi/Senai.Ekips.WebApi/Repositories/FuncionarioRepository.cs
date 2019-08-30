﻿using Senai.Ekips.WebApi.Domains;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Senai.Ekips.WebApi.Repositories
{
    public class FuncionarioRepository
    {
        public List<Funcionarios> Listar()
        {
            using (EkipsContext ctx = new EkipsContext())
            {
                return ctx.Funcionarios.ToList();
            }
        }
        public void Cadastrar(Funcionarios funcionarios)
        {
            using (EkipsContext ctx = new EkipsContext())
            {
                ctx.Funcionarios.Add(funcionarios);
                ctx.SaveChanges();
            }
        }
        public void Atualizar(Funcionarios funcionarios)
        {
            using(EkipsContext ctx = new EkipsContext())
            {
                Funcionarios FuncionarioBuscado = ctx.Funcionarios.FirstOrDefault(x => x.IdFuncionario == funcionarios.IdFuncionario);
                FuncionarioBuscado.Nome = funcionarios.Nome;
                ctx.Funcionarios.Update(FuncionarioBuscado);
                ctx.SaveChanges();
            }
        }
        public Funcionarios BuscarPorId(int id)
        {
            using(EkipsContext ctx = new EkipsContext())
            {
                return ctx.Funcionarios.FirstOrDefault(x => x.IdFuncionario == id);
            }
        }
        public void Deletar(int id)
        {
            using(EkipsContext ctx = new EkipsContext())
            {
                Funcionarios Funcionario = ctx.Funcionarios.Find(id);

                ctx.Funcionarios.Remove(Funcionario);

                ctx.SaveChanges();
            }
        }
    }
}
