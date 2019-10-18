using Microsoft.EntityFrameworkCore;
using ProPlus.Comum.Repositorios.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace ProPlus.Comum.Repositorios.Entity
{
    public abstract class RepositorioComum<TDominio, TChave> : IRepositorioComum<TDominio, TChave>
            where TDominio : class
    {
        protected DbContext _context;
        public RepositorioComum(DbContext context)
        {
            _context = context;
        }

        public void Atualizar(TDominio dominio)
        {
            _context.Entry(dominio).State = EntityState.Modified;
            _context.SaveChanges();
        }

        public void Excluir(TDominio dominio)
        {
            _context.Entry(dominio).State = EntityState.Deleted;
            _context.SaveChanges();
        }

        public void ExcluirPorID(TChave id)
        {
            TDominio dominio = SelecionarPorID(id);
            Excluir(dominio);
        }

        public void Inserir(TDominio dominio)
        {
            _context.Set<TDominio>().Add(dominio);
            _context.SaveChanges();
        }

        public List<TDominio> Selecionar(Expression<Func<TDominio, bool>> where = null)
        {
            DbSet<TDominio> DbSet = _context.Set<TDominio>();
            if (where.Equals(null))
            {
                return DbSet.ToList();
            }
            else
            {
                return DbSet.Where(where).ToList();
            }
        }

        public TDominio SelecionarPorID(TChave id)
        {
            return _context.Set<TDominio>().Find(id);
        }
    }
}
