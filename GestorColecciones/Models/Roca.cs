using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace GestorColecciones.Models
{
    public class Roca
    {
        public int ID { get; set; }

        [Required]
        public string Nombre { get; set; }

        [Required]
        public string Tipo { get; set; }

        [Required]
        public string Ubicacion { get; set; }

        [Required]
        [Range(0.01, 100.0, ErrorMessage = "El peso debe estar entre 0.01 y 100.0")]
        public double Peso { get; set; }

        [Required]
        public string Descripcion { get; set; }
    }
}