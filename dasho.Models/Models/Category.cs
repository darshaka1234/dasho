using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace dasho.Models
{
    public class Category
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [DisplayName("Category Name")]
        public required string  Name { get; set; }

        [Required]
        [Range(0, 100)]
        [DisplayName("Display Order")]
        public int DisplayOrder { get; set; }

    }
}
