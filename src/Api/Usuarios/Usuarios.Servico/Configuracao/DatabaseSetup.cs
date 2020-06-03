using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Usuarios.Infraestrutura.Dados.Contexto;

namespace Usuarios.Servico.Configuracao
{
    public static class DatabaseSetup
    {
        public static void AddDatabaseSetup(this IServiceCollection services, IConfiguration configuration)
        {
            if (services == null) throw new ArgumentNullException(nameof(services));

            services.AddDbContext<Contexto>(options =>
                options.UseSqlServer(configuration.GetConnectionString("DefaultConnection")));
        }

    }
}
