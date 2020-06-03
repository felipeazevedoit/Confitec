using System;
using System.Collections.Generic;
using System.Text;
using Usuarios.Aplicacao.Modelo;

namespace Usuarios.Aplicacao.Interfaces
{
    interface IUsuarioServico: IDisposable
    {
        void Adicionar(UsuarioModelo usuarioModelo);
        IEnumerable<UsuarioModelo> Listar();
        UsuarioModelo ObterPorId(int id);
        void Alterar(UsuarioModelo usuarioModelo);
        void Remove(int id);
    }
}
