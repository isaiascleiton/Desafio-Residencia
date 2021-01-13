using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Dinda.Models
{
    public abstract class Base
    {
        public int Id { get; set; }


        [Display(Name="Nome")]
        [Required(ErrorMessage = "Este campo é obrigatório")]
        public string Name { get; set; }


        [Display(Name = "CPF")]
        [Required(ErrorMessage = "Este campo é obrigatório")]
        public string Cpf { get; set; }


        [Display(Name = "Local")]
        [Required(ErrorMessage = "Este campo é obrigatório")]
        public string Location { get; set; }


        [Display(Name = "Nascimento")]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:yyyy-MM-dd}")]
        [DataType(DataType.Date, ErrorMessage = "Data em formato inválido")]
        [Required(ErrorMessage = "Este campo é obrigatório")]
        public DateTime DateBirth { get; set; }


        [Display(Name = "Celular")]
        public string PhoneNumber { get; set; }


        [Required(ErrorMessage = "Este campo é obrigatório")]
        public string Email { get; set; }


        [Display(Name = "Interesses")]
        [Required(ErrorMessage = "Este campo é obrigatório")]
        public string Hobbies { get; set; }


        [Display(Name = "Dias Disponíveis")]
        [Required(ErrorMessage = "Este campo é obrigatório")]
        public string DaysAvailable { get; set; }
    }
}
