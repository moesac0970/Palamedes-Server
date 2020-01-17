using System.ComponentModel.DataAnnotations;

namespace Palamedes.API.Models
{
    public class EntityBase
    {
        [Required]
        public long Id { get; set; }
    }
}
