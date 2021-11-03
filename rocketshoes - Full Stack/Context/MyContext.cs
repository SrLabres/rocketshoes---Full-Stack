using Microsoft.EntityFrameworkCore;
using rocketshoes___Full_Stack.Entity;
using rocketshoes___Full_Stack.Mapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace rocketshoes___Full_Stack.Context
{
    public class MyContext : DbContext
    {
        public DbSet<Usuario> Usuarios { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=Josue-Desktop;Initial Catalog=RocketShoes;Integrated Security=True;Pooling=False");
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            builder.Entity<Usuario>(new UsuarioMapping().Configure);
            builder.Entity<Produto>(new ProdutoMapping().Configure);
            builder.Entity<Compra>(new CompraMapping().Configure);
        }
    }
}
