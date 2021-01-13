using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Dinda.Models
{
    public class Madrinha : Base
    {
        [Display(Name = "Pode ensinar")]
        [Required(ErrorMessage = "Este campo é obrigatório")]
        public string CanTeach { get; set; }
    }
}
