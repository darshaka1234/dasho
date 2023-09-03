using System.ComponentModel.DataAnnotations;

namespace dasho.Models
{
    public class Category
    {
        public int Id { get; set; }
        [Required]
        public int Name { get; set; }
        public int DisplayOrder { get; set; }
    }
}
