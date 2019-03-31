using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace TareaHTMLHelper.Models
{
    public class Formulario
    {
        [Required]
        public String Cedula { get; set; }
        [MinLength(11)]

        [Required]
        public String Nombre { get; set; }

        [Required]
        public String Apellido { get; set; }

        [Range(15, 100)]
        public int Edad { get; set; }

        public String Telefono { get; set; }
        [MinLength(10)]

        public String CorreoElectronico { get; set; }
        [DataType(DataType.EmailAddress)]
        [Required(ErrorMessage = "Por favor coloque su Email")]
        [RegularExpression(@"^\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*$", ErrorMessage = "Este Email no es validad.")]

        public String Genero { get; set; }

        public String EstadoCivil { get; set; }

        public String Hobbys { get; set; }
    }
}