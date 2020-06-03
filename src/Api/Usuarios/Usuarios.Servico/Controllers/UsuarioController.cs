using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Usuarios.Aplicacao.Interfaces;
using Usuarios.Aplicacao.Modelo;

namespace Usuarios.Servico.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UsuarioController : ApiController
    {
        private readonly IUsuarioServico _iUsuarioServico;

        public UsuarioController(IUsuarioServico iUsuarioServico)
        {
            _iUsuarioServico = iUsuarioServico;
        }

      
        [HttpGet]
        public IActionResult Get()
        {
            return Response(_iUsuarioServico.Listar().ToList());
        }

        [HttpGet]
        [Route("Usuario/{id:int}")]
        public IActionResult Get(int id)
        {
            return Response(_iUsuarioServico.ObterPorId(id));
        }


        [HttpPost]
        public IActionResult Post([FromBody]UsuarioModelo usuarioModelo)
        {
            if (!ModelState.IsValid)
            {
                return Response(_iUsuarioServico.Adicionar(usuarioModelo));
            }
            else
            {
                return BadRequest(new
                {
                    success = false,
                    errors = usuarioModelo
                });
            }
        }

        [HttpPut("{UsuarioModelo}")]
        public IActionResult Put([FromBody]UsuarioModelo usuarioModelo)
        {
            if (!ModelState.IsValid)
            {
                return Response(_iUsuarioServico.Alterar(usuarioModelo));
            }
            else
            {
                return BadRequest(new
                {
                    success = false,
                    errors = usuarioModelo
                });
            }
        }


        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            _iUsuarioServico.Remove(id);
            return Response();
        }
    }
}
