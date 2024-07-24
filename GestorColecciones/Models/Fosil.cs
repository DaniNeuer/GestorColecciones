using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace GestorColecciones.Models
{
    public class Fosil
    {
        public int ID { get; set; }

        [Required]
        public string Nombre { get; set; }

        [Required]
        public string Especie { get; set; }

        [Required]
        public string Periodo { get; set; }

        [Required]
        [Range(0.01, 1.0, ErrorMessage = "El peso debe estar entre 0.01 y 1.0")]
        public double Peso { get; set; }

        [Required]
        public string Ubicacion { get; set; }

        [Required]
        public string Descripcion { get; set; }
    }

}