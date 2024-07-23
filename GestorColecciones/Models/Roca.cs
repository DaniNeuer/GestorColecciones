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
        public string Nombre { get; set; }
        public string Tipo { get; set; }
        public string Ubicacion { get; set; }
    

    }
}