using Microsoft.Extensions.DependencyInjection;
using System;
using Usuarios.Aplicacao.Interfaces;
using Usuarios.Aplicacao.Servicos;
using Usuarios.Dominio.Interfaces.Repositorio;
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
            services.AddScoped<IUsuarioServico, UsuarioServico>();

            // Infraestrutura - Dados 
            services.AddScoped<IUsuario, UsuarioRepositorio>();
            services.AddScoped<Contexto>();

        }
    }
}
