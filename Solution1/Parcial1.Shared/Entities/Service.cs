using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parcial1.Shared.Entities
{
    public class Service
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "El campo {0} es obligatorio")]
        [Display(Name = "Nombre del servicio")]
        [MaxLength(100, ErrorMessage = "El campo {0} no puede tener más de {1} caracteres")]
        public string ServiceName { get; set; } = null!;
        [Required(ErrorMessage = "El campo {0} es obligatorio")]
        [Display(Name = "Descripción del servicio")]
        [MaxLength(500, ErrorMessage = "El campo {0} no puede tener más de {1} caracteres")]
        public string ServiceDescription { get; set; } = null!;
        [Required(ErrorMessage = "El campo {0} es obligatorio")]
        [Display(Name = "Precio del servicio")]
        [Range(0, double.MaxValue, ErrorMessage = "El campo {0} debe ser un valor positivo")]
        public float Price { get; set; }
        [Required(ErrorMessage = "El campo {0} es obligatorio")]
        [Display(Name = "Técnico asignado")]
        public int TechnicianId { get; set; } // Relación con Technician
        [Required(ErrorMessage = "El campo {0} es obligatorio")]
        [Display(Name = "Paquete asociado")]
        public int PackageId { get; set; } // Relación con Package
        [Display(Name = "Comentarios adicionales")]
        [MaxLength(500, ErrorMessage = "El campo {0} no puede tener más de {1} caracteres")]
        public string? AdditionalComments { get; set; }
        public bool Active {  get; set; }
    }
}
