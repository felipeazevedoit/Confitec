using Microsoft.EntityFrameworkCore;
using System.Diagnostics.CodeAnalysis;
using Usuarios.Dominio.Entidades;
using Usuarios.Infraestrutura.Dados.Mapeamento;

namespace Usuarios.Infraestrutura.Dados.Contexto
{
    public class Contexto: DbContext
    {
        public DbSet<Usuario> Usuario { get; set; }

        public Contexto(DbContextOptions<Contexto> options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new UsuarioMap());

            base.OnModelCreating(modelBuilder);
        }
    }
}
