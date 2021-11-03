using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using rocketshoes___Full_Stack.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace rocketshoes___Full_Stack.Mapping
{
    public class EnderecoMapping : IEntityTypeConfiguration<Endereco>
    {
        public void Configure(EntityTypeBuilder<Endereco> builder)
        {
            builder.ToTable("Endereco");
            builder.HasKey(prop => prop.Id);
            builder.HasOne<Usuario>(p => p.Usuario).WithMany(p => p.Enderecos).HasForeignKey(p => p.UsuarioId);
        }
    }
}
