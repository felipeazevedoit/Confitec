using System;
using System.Collections.Generic;
using Usuarios.Aplicacao.Modelo;

namespace Usuarios.Aplicacao.Interfaces
{
    public interface IUsuarioServico: IDisposable
    {
        UsuarioModelo Adicionar(UsuarioModelo usuarioModelo);
        IEnumerable<UsuarioModelo> Listar();
        UsuarioModelo ObterPorId(int id);
        UsuarioModelo Alterar(UsuarioModelo usuarioModelo);
        void Remove(int id);
    }
}
