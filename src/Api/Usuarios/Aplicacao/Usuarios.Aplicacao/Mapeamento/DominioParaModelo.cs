using AutoMapper;
using Usuarios.Aplicacao.Modelo;
using Usuarios.Dominio.Entidades;

namespace Usuarios.Aplicacao.Mapeamento
{
    public class DominioParaModelo: Profile
    {
        public DominioParaModelo()
        {
            CreateMap<Usuario, UsuarioModelo>();
        }
    }
}
