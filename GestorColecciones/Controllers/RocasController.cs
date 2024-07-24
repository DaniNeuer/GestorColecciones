using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Data.Entity;
using GestorColecciones.DAL;
using GestorColecciones.Models;

namespace GestorColecciones.Controllers
{
    // Definición del controlador RocasController que maneja las solicitudes HTTP relacionadas con las rocas
    public class RocasController : ApiController
    {
        // Instancia del contexto de la base de datos
        private GestorColeccion bd = new GestorColeccion();

        // Método GET para obtener todas las rocas
        [HttpGet]
        public IEnumerable<Roca> ObtenerRocas()
        {
            // Retorna una lista de todas las rocas en la base de datos
            return bd.Rocas.ToList();
        }

        // Método GET para obtener una roca específica por ID
        [HttpGet]
        public IHttpActionResult ObtenerRoca(int id)
        {
            // Busca la roca en la base de datos por ID
            var roca = bd.Rocas.Find(id);
            // Si no se encuentra la roca, retorna un estado NotFound
            if (roca == null)
                return NotFound();
            // Si se encuentra la roca, retorna un estado Ok con la roca
            return Ok(roca);
        }

        // Método POST para crear una nueva roca
        [HttpPost]
        //[Route("api/rocas")]
        public IHttpActionResult CrearRoca(Roca roca)
        {
            // Verifica si el modelo es válido
            if (!ModelState.IsValid)
                return BadRequest(ModelState);
            // Agrega la nueva roca a la base de datos
            bd.Rocas.Add(roca);
            // Guarda los cambios en la base de datos
            bd.SaveChanges();
            // Retorna un estado Created con la ruta del nuevo recurso y la roca creada
            return CreatedAtRoute("DefaultApi", new { id = roca.ID }, roca);
        }

        // Método PUT para actualizar una roca existente
        [HttpPut]
        public IHttpActionResult ActualizarRoca(int id, Roca roca)
        {
            // Verifica si el modelo es válido
            if (!ModelState.IsValid)
                return BadRequest(ModelState);
            // Verifica si el ID de la roca coincide con el ID del parámetro
            if (id != roca.ID)
                return BadRequest();
            // Marca la roca como modificada en el contexto de la base de datos
            bd.Entry(roca).State = EntityState.Modified;
            // Guarda los cambios en la base de datos
            bd.SaveChanges();
            // Retorna un estado NoContent para indicar que la actualización fue exitosa
            return StatusCode(HttpStatusCode.NoContent);
        }

        // Método DELETE para borrar una roca existente
        [HttpDelete]
        public IHttpActionResult BorrarRoca(int id)
        {
            // Busca la roca en la base de datos por ID
            var roca = bd.Rocas.Find(id);
            // Si no se encuentra la roca, retorna un estado NotFound
            if (roca == null)
                return NotFound();
            // Remueve la roca de la base de datos
            bd.Rocas.Remove(roca);
            // Guarda los cambios en la base de datos
            bd.SaveChanges();
            // Retorna un estado Ok con la roca eliminada
            return Ok(roca);
        }
    }
}
