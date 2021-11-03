using rocketshoes___Full_Stack.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace rocketshoes___Full_Stack.Mapping
{
    public class Categoria
    {
        public int Id { get; set; }
        public string Nome { get; set; }

        public IEnumerable<Produto> Produtos { get; set; }
    }
}
