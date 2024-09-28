using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parcial1.Shared.Entities
{
    public class Classification
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "El campo {0} es obligatorio")]
        [Display(Name = "Clasificación")]
        [MaxLength(50, ErrorMessage = "El campo {0} no puede tener más de {1} caracteres")]
        public string Name { get; set; } = null!;
        [Display(Name = "Descripción")]
        [MaxLength(500, ErrorMessage = "El campo {0} no puede tener más de {1} caracteres")]
        public string Description { get; set; } = null!;
        [Display(Name = "Nivel de Importancia")]
        [Range(1, 5, ErrorMessage = "El campo {0} debe estar entre {1} y {2}")]
        public int ImportanceLevel { get; set; } 
        public bool Active { get; set; }        
    }
    
}

