using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace Core.Entity
{
    public class Livro : EntityBase
    {
        public required string Nome { get; set; }
        public required string Editora { get; set; }
        public ICollection<Pedido> Pedidos { get; set; }
    }
}
