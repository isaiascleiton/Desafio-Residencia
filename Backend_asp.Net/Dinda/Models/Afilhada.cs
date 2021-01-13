using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Dinda.Models
{
    public class Afilhada : Base
    {
        [Display(Name = "Quer aprender")]
        [Required(ErrorMessage = "Este campo é obrigatório")]
        public string WantToLearn { get; set; }
    }
}
