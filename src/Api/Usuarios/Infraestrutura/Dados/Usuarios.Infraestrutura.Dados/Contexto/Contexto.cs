﻿using Microsoft.EntityFrameworkCore;
using Usuarios.Dominio.Entidades;

namespace Usuarios.Infraestrutura.Dados.Contexto
{
    public class Contexto: DbContext
    {
        public DbSet<Usuario> Usuario { get; set; }

        public Contexto(DbContextOptions<Contexto> options)
        : base(options)
        {

        }
    }
}