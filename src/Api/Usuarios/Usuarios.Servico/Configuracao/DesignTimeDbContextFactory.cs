﻿using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Usuarios.Infraestrutura.Dados.Contexto;

namespace Usuarios.Servico.Configuracao
{
    public class DesignTimeDbContextFactory : IDesignTimeDbContextFactory<Contexto>
    {

        Contexto IDesignTimeDbContextFactory<Contexto>.CreateDbContext(string[] args)
        {
            IConfigurationRoot configuration = new ConfigurationBuilder()
             .SetBasePath(Directory.GetCurrentDirectory())
             .AddJsonFile("appsettings.json")
             .Build();
            var builder = new DbContextOptionsBuilder<Contexto>();
            var connectionString = configuration.GetConnectionString("DefaultConnection");
            builder.UseSqlServer(connectionString);
            return new Contexto(builder.Options);
        }
    }
}
