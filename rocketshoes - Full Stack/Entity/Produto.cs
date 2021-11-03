using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace rocketshoes___Full_Stack.Entity
{
    public class Produto
    {
        public int Id { get; set; }
        public string Titulo { get; set; }
        public string Descricao { get; set; }
        public string imagem { get; set; }
        public float Valor { get; set; }
        public int Estoque { get; set; }

        [ForeignKey("Categoria")]
        public int CategoriaId { get; set; }

    }
}
