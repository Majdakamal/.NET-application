using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace APPTest.Models
{
    public class Produit
    {
        public int Id { get; set; }

        [Required]
        public string? Title { get; set; }

        [DataType(DataType.Date)]
        public DateTime ReleaseDate { get; set; }

        [Required]
        public decimal Price { get; set; }

        [NotMapped] // This attribute is used to indicate that this property is not mapped to a database column
        [Display(Name = "Image")]
        public IFormFile ImageFile { get; set; }

        public string? ImageUrl { get; set; }
    }
}
