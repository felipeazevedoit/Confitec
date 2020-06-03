using MediatR;
using Microsoft.Extensions.DependencyInjection;
using System;
using Usuarios.Aplicacao.Servicos;
using Usuarios.Infraestrutura.Dados.Contexto;
using Usuarios.Infraestrutura.Dados.Repositorio;

namespace Usuarios.Servico.Configuracao
{
    public static class DependencyInjectionSetup
    {
        public static void AddDependencyInjectionSetup(this IServiceCollection services)
        {
            if (services == null) throw new ArgumentNullException(nameof(services));

            // Aplicacao
            services.AddScoped<UsuarioServico, UsuarioServico>();


            // Infraestrutura - Dados 
            services.AddScoped<UsuarioRepositorio, UsuarioRepositorio>();
            services.AddScoped<Contexto>();


        }
    }
}
