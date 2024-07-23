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
        public string Nombre { get; set; }
        public string Especie { get; set; }
        public string Periodo { get; set; }
    }

}