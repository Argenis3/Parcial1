using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parcial1.Shared.Entities
{
    public class Scheduling
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "El campo {0} es obligatorio")]
        [Display(Name = "Cliente")]
        [MaxLength(255, ErrorMessage = "El campo {0} no puede tener más de {1} caracteres")]
        public string ClientName { get; set; } = null!;
        [Required(ErrorMessage = "El campo {0} es obligatorio")]
        [Display(Name = "Dirección del servicio")]
        [MaxLength(255, ErrorMessage = "El campo {0} no puede tener más de {1} caracteres")]
        public string Address { get; set; } = null!;
        [Required(ErrorMessage = "El campo {0} es obligatorio")]
        [Display(Name = "Fecha y hora de la cita")]
        public DateTime AppointmentDate { get; set; }
        [Required(ErrorMessage = "El campo {0} es obligatorio")]
        [Display(Name = "Tipo de servicio")]
        [MaxLength(100, ErrorMessage = "El campo {0} no puede tener más de {1} caracteres")]
        public string ServiceType { get; set; } = null!;
        [Display(Name = "Comentarios adicionales")]
        [MaxLength(500, ErrorMessage = "El campo {0} no puede tener más de {1} caracteres")]
        public string? AdditionalComments { get; set; }
        public bool Active { get; set; }  
    }
}
