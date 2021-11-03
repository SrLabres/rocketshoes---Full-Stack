using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace rocketshoes___Full_Stack.Entity
{
    public class Compra
    {
        public int Id { get; set; }
        public DateTime Data { get; set; }


        [ForeignKey("Usuario")]
        public int UsuarioId { get; set; }

        public Usuario Usuario { get; set; }

        public int ProdutoId { get; set; }

        public int Quantidade { get; set; }

    }
}
