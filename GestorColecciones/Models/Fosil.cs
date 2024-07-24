using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace GestorColecciones.Models
{
    // Definición de la clase Fosil
    public class Fosil
    {
        // Propiedad ID que es la clave primaria de la entidad
        public int ID { get; set; }

        // Propiedad Nombre, es requerida
        [Required]
        public string Nombre { get; set; }

        // Propiedad Especie, es requerida
        [Required]
        public string Especie { get; set; }

        // Propiedad Periodo, es requerida
        [Required]
        public string Periodo { get; set; }

        // Propiedad Peso, es requerida y debe estar entre 0.01 y 1.0
        [Required]
        [Range(0.01, 1.0, ErrorMessage = "El peso debe estar entre 0.01 y 1.0")]
        public double Peso { get; set; }

        // Propiedad Ubicacion, es requerida
        [Required]
        public string Ubicacion { get; set; }

        // Propiedad Descripcion, es requerida
        [Required]
        public string Descripcion { get; set; }
    }

}