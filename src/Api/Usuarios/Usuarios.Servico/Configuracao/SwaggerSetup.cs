using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.OpenApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Usuarios.Servico.Configuracao
{
    public static class SwaggerSetup
    {
        public static void AddSwaggerSetup(this IServiceCollection services)
        {
            if (services == null) throw new ArgumentNullException(nameof(services));

            services.AddSwaggerGen(s =>
            {
                s.SwaggerDoc("v1", new OpenApiInfo
                {
                    Version = "v1",
                    Title = "Confitec Teste - Usuarios",
                    Description = "Teste para vaga de DEV Sr",
                    Contact = new OpenApiContact { Name = "Felipe Azevedo", Email = "felipe.azevedoit@gmail.com"},
                }); 

               
            });
        }


    }
}
