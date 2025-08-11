using System.ComponentModel.DataAnnotations;

namespace mascotaedu.Models
{
    public class Product
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "El nombre del producto es obligatorio")]
        [StringLength(150)]
        public string Name { get; set; }

        [StringLength(500)]
        public string Description { get; set; }

        [Range(0.0, 99999.99)]
        [DataType(DataType.Currency)]
        public decimal Price { get; set; }

        public int Stock { get; set; }

        [StringLength(200)]
        public string ImageUrl { get; set; }
    }
}
