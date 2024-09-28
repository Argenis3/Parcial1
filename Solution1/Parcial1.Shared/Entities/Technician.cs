using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parcial1.Shared.Entities
{
    public class Technician
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "El campo {0} es obligatorio")]
        [Display(Name = "Nombre del técnico")]
        [MaxLength(255, ErrorMessage = "El campo {0} no puede tener más de {1} caracteres")]
        public string TechnicianName { get; set; } = null!;
        [Required(ErrorMessage = "El campo {0} es obligatorio")]
        [Display(Name = "Especialidad")]
        [MaxLength(100, ErrorMessage = "El campo {0} no puede tener más de {1} caracteres")]
        public string Specialty { get; set; } = null!;

        [Required(ErrorMessage = "El campo {0} es obligatorio")]
        [Display(Name = "Número de teléfono")]
        [Phone(ErrorMessage = "El campo {0} no tiene un formato válido")]
        public string PhoneNumber { get; set; } = null!;
        [Required(ErrorMessage = "El campo {0} es obligatorio")]
        [Display(Name = "Disponibilidad")]
        public bool Active { get; set; }
        [Display(Name = "Comentarios adicionales")]
        [MaxLength(500, ErrorMessage = "El campo {0} no puede tener más de {1} caracteres")]
        public string? AdditionalComments { get; set; }
    }
}
