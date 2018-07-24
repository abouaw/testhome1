using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace TestHome1.Models
{
    public class Employee
    {
        [Key]
        public int Id { get; set; }

        [StringLength(30)]
        [Required(ErrorMessage = "Champ obligatoire")]
        public String Nom { get; set; }

        [DataType(DataType.EmailAddress)]
        [Required(ErrorMessage = "Champ obligatoire")]
        public String Email { get; set; }

        [DataType(DataType.Date)]
        [Required(ErrorMessage = "Champ obligatoire")]
        [display(Name= "Date d'embauche")]
        public DateTime DateEmbauche { get; set; }
    }
}
