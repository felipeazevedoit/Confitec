using System;
using AutoMapper;
using Usuarios.Aplicacao.Mapeamento;
using Microsoft.Extensions.DependencyInjection;


namespace Usuarios.Servico.Configuracao
{
    public static class AutoMapperSetup
    {
        public static void AddAutoMapperSetup(this IServiceCollection services)
        {
            if (services == null) throw new ArgumentNullException(nameof(services));

            services.AddAutoMapper(typeof(DominioParaModelo), typeof(ModeloParaDominio));
        }
    }
}
