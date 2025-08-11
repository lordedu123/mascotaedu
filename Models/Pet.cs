using System;
using System.ComponentModel.DataAnnotations;

namespace mascotaedu.Models
{
    public class Pet
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "El nombre es obligatorio")]
        [StringLength(100)]
        public string Name { get; set; }

        [Required(ErrorMessage = "El tipo es obligatorio")]
        [Display(Name = "Tipo (ej. Perro, Gato)")]
        public string Type { get; set; }

        [Range(0, 100)]
        public int Age { get; set; }

        [Display(Name = "Fecha de registro")]
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;

        [StringLength(500)]
        public string Notes { get; set; }
    }
}
