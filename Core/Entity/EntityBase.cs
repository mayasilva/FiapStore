using System.ComponentModel.DataAnnotations;

namespace Core.Entity
{
    public class EntityBase
    {
        [Key]
        public int Id { get; set; }
        public DateTime DataCriacao { get; set; }
    }
}
