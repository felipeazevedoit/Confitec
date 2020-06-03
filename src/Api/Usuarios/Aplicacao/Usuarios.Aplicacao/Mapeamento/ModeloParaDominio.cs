using AutoMapper;
using Usuarios.Aplicacao.Modelo;
using Usuarios.Dominio.Entidades;

namespace Usuarios.Aplicacao.Mapeamento
{
    public class ModeloParaDominio: Profile
    {
        public ModeloParaDominio()
        {
            CreateMap<UsuarioModelo, Usuario>()
                .ConstructUsing(c => new Usuario(c.Id, c.Nome, c.Sobrenome, c.DataNascimento, c.Escolaridade));
        }
    }
}
