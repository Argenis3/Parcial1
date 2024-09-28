using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parcial1.Shared.Entities
{
    public class Package
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "El campo {0} es obligatorio")]
        [Display(Name = "Nombre del paquete")]
        [MaxLength(100, ErrorMessage = "El campo {0} no puede tener más de {1} caracteres")]
        public string PackageName { get; set; } = null!;
        [Required(ErrorMessage = "El campo {0} es obligatorio")]
        [Display(Name = "Descripción del paquete")]
        [MaxLength(500, ErrorMessage = "El campo {0} no puede tener más de {1} caracteres")]
        public string PackageDescription { get; set; } = null!;
        [Required(ErrorMessage = "El campo {0} es obligatorio")]
        [Display(Name = "Precio del paquete")]
        [Range(0, double.MaxValue, ErrorMessage = "El campo {0} debe ser un valor positivo")]
        public float Price { get; set; }
        [Required(ErrorMessage = "El campo {0} es obligatorio")]
        [Display(Name = "Duración estimada (minutos)")]
        [Range(1, 600, ErrorMessage = "El campo {0} debe ser un valor entre {1} y {2}")]
        public int EstimatedDuration { get; set; }
        [Display(Name = "Comentarios adicionales")]
        [MaxLength(500, ErrorMessage = "El campo {0} no puede tener más de {1} caracteres")]
        public string? AdditionalComments { get; set; }
        public bool Active {  get; set; }
    }
}
