using AutoMapper;
using AutoMapper.QueryableExtensions;
using System;
using System.Collections.Generic;
using Usuarios.Aplicacao.Interfaces;
using Usuarios.Aplicacao.Modelo;
using Usuarios.Dominio.Entidades;
using Usuarios.Dominio.Interfaces.Repositorio;
using Usuarios.Infraestrutura.Dados.Repositorio;

namespace Usuarios.Aplicacao.Servicos
{
    public class UsuarioServico : IUsuarioServico
    {
        private readonly IMapper _mapper;
        private readonly IUsuario _iUsuario;

        public UsuarioServico(IMapper iMapper, IUsuario iUsuario)
        {
            _mapper = iMapper;
            _iUsuario = iUsuario;
        }

        public void Adicionar(UsuarioModelo usuarioModelo)
        {
            _iUsuario.Adicionar(_mapper.Map<Usuario>(usuarioModelo));
        }

        public void Alterar(UsuarioModelo usuarioModelo)
        {
            _iUsuario.Alterar(_mapper.Map<Usuario>(usuarioModelo));
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<UsuarioModelo> Listar()
        {
            return _iUsuario.Listar().ProjectTo<UsuarioModelo>(_mapper.ConfigurationProvider);
        }

        public UsuarioModelo ObterPorId(int id)
        {
            return _mapper.Map<UsuarioModelo>(_iUsuario.ObterPorId(id));
        }

        public void Remove(int id)
        {
            _iUsuario.Excluir(id);
        }
    }
}
