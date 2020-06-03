using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Usuarios.Dominio.Entidades;

namespace Usuarios.Infraestrutura.Dados.Mapeamento
{
    public class UsuarioMap : IEntityTypeConfiguration<Usuario>
    {


        public void Configure(EntityTypeBuilder<Usuario> builder)
        {
            builder.Property(c => c.Id)
             .HasColumnName("Id");

            builder.Property(c => c.Nome)
                .HasColumnType("varchar(100)")
                .HasMaxLength(100)
                .IsRequired();
            builder.Property(c => c.Email)
              .HasColumnType("varchar(300)")
              .HasMaxLength(300)
              .IsRequired();

            builder.Property(c => c.Sobrenome)
                .HasColumnType("varchar(100)")
                .HasMaxLength(100);
        }
    }
}
