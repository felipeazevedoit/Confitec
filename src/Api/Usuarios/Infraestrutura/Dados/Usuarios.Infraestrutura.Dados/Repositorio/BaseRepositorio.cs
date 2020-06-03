using System;
using System.Collections.Generic;
using System.Linq;
using Usuarios.Dominio.Interfaces.Repositorio;

namespace Usuarios.Infraestrutura.Dados.Repositorio
{
    public class BaseRepositorio<T> : IDisposable, IBase<T> where T : class
    {
        protected readonly Contexto.Contexto _Contexto;

        public BaseRepositorio(Contexto.Contexto contexto)
        {
            _Contexto = contexto;
        }

        public T Adicionar(T obj)
        {
            _Contexto.Set<T>().Add(obj);
            _Contexto.SaveChanges();
            return obj;
        }

        public T Alterar(T obj)
        {
            _Contexto.Entry(obj).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            _Contexto.SaveChanges();
            return obj;
        }

        public void Dispose()
        {
            _Contexto.Dispose();
            GC.SuppressFinalize(this);
        }

        public void Excluir(int id)
        {
            _Contexto.Set<T>().Remove(this.ObterPorId(id));
            _Contexto.SaveChanges();
        }

        public IQueryable<T> Listar()
        {
            return _Contexto.Set<T>();
        }

        public T ObterPorId(int id)
        {
            return _Contexto.Set<T>().Find(id);
        }
    }
}
