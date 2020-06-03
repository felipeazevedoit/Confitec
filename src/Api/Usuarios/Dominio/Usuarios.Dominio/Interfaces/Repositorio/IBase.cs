using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;


namespace Usuarios.Dominio.Interfaces.Repositorio
{
    public interface IBase<T> : IDisposable where T: class
    {
        T Adicionar(T obj);
        T Alterar(T obj);
        IQueryable<T> Listar();
        T ObterPorId(int id);
        void Excluir(int id);
    }
}
