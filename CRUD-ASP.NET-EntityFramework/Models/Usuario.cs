using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CRUD_ASP.NET_EntityFramework.Models
{
    public class Usuario
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "El nombre es obligatorio")]
        public string Nombre { get; set; }

        [Required(ErrorMessage = "El Apellido es obligatorio")]
        public string Apellido { get; set; }

        [Required(ErrorMessage = "El DNI es obligatorio")]
        public string DNI { get; set; }

        [Display(Name = "Teléfono de contacto")]
        public string Telefono { get; set; }

        public string Email { get; set; }
    }
}
