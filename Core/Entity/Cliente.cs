using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Core.Entity
{
    [Table("Cliente")]
    public class Cliente : EntityBase
    {
        [Required]
        [Column("Nome")]
        public required string Nome { get; set; }
        public DateTime? DataDeNascimento { get; set; }
        public required string CPF { get; set; }
        public ICollection<Pedido> Pedidos { get; set; }
    }
}
