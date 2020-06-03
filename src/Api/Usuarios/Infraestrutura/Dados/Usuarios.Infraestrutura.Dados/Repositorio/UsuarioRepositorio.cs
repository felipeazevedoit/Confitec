using System;
using System.Collections.Generic;
using System.Text;
using Usuarios.Dominio.Entidades;

namespace Usuarios.Infraestrutura.Dados.Repositorio
{
    public class UsuarioRepositorio : BaseRepositorio<Usuario>
    {
        public UsuarioRepositorio(Contexto.Contexto contexto)
              : base(contexto)
        {

        }
    }
}
