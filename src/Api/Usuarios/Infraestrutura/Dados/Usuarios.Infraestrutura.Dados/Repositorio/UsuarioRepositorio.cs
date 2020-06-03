using System;
using System.Collections.Generic;
using System.Text;
using Usuarios.Dominio.Entidades;
using Usuarios.Dominio.Interfaces.Repositorio;

namespace Usuarios.Infraestrutura.Dados.Repositorio
{
    public class UsuarioRepositorio : BaseRepositorio<Usuario>, IUsuario
    {
        public UsuarioRepositorio(Contexto.Contexto contexto)
              : base(contexto)
        {

        }
    }
}
