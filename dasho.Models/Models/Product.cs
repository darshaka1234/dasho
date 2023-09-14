using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace dasho.Models
{
    public class Product
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Title { get; set; }
       
        public string Description { get; set; }

        public string  Author { get; set;}
        [Required]
        public string ISBN { get; set;}
        [Range(1, 1000)]
        [Display(Name = "List Price")]
        public double ListPrice { get; set;}
        [Range(1, 1000)]
        [Display(Name = "Price for 1-50")]
        public double Price { get; set;}
        [Range(1, 1000)]
        [Display(Name = "Price for 50+")]
        public double Price50 { get; set;}
        [Range(1, 1000)]
        [Display(Name = "Price for 100+")]
        public double Price100 { get; set;}
    }
}
