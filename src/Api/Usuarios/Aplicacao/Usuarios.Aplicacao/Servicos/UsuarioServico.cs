using AutoMapper;
using AutoMapper.QueryableExtensions;
using System;
using System.Collections.Generic;
using Usuarios.Aplicacao.Interfaces;
using Usuarios.Aplicacao.Modelo;
using Usuarios.Dominio.Entidades;
using Usuarios.Dominio.Interfaces.Repositorio;

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

        public UsuarioModelo Adicionar(UsuarioModelo usuarioModelo)
        {
            try
            {
                return _mapper.Map<UsuarioModelo>(_iUsuario.Adicionar(_mapper.Map<Usuario>(usuarioModelo)));
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                return null;
            }
        }

        public UsuarioModelo Alterar(UsuarioModelo usuarioModelo)
        {
            try
            {
                return _mapper.Map<UsuarioModelo>(_iUsuario.Alterar(_mapper.Map<Usuario>(usuarioModelo)));
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                return null;
            }
        }

        public void Dispose()
        {
            _iUsuario.Dispose();
        }

        public IEnumerable<UsuarioModelo> Listar()
        {
            try
            {
                return _iUsuario.Listar().ProjectTo<UsuarioModelo>(_mapper.ConfigurationProvider);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                return null;
            }
        }

        public UsuarioModelo ObterPorId(int id)
        {
            try
            {
                return _mapper.Map<UsuarioModelo>(_iUsuario.ObterPorId(id));
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                return null;
            }
        }

        public void Remove(int id)
        {
            try
            {
                _iUsuario.Excluir(id);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }
    }
}
