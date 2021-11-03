using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using rocketshoes___Full_Stack.Entity;

namespace rocketshoes___Full_Stack.Mapping
{
    public class CompraMapping : IEntityTypeConfiguration<Compra>
    {
        public void Configure(EntityTypeBuilder<Compra> builder)
        {
            builder.ToTable("Compra");
            builder.HasKey(prop => prop.Id);
            builder.Property(p => p.Id).ValueGeneratedOnAdd();

            builder.HasOne<Usuario>(p => p.Usuario).WithMany(p => p.Compras).HasForeignKey(p => p.UsuarioId);
        }
    }
}

