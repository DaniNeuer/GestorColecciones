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
    public class FosilesController : ApiController
    {
        private GestorColeccion bd = new GestorColeccion();

        [HttpGet]
        [Route("api/fosiles")]
        public IEnumerable<Fosil> ObtenerFosiles()
        {
            //se rtorna una lista de fosiles
            return bd.Fosiles.ToList();
        }

        [HttpGet]
        //El metodo se usa para obtner un fosil por el id
        public IHttpActionResult ObtenerFosil(int id)
        {
            //realizamos la busqueda del fosil por el id usando el metodo Find()
            var fosil = bd.Fosiles.Find(id);
            // si no se encontro el fosil, se envia lo retornado al usar el metodo NotFound()
            if (fosil == null)
                return NotFound();
            //en caso de que si se encontro se devuelve un Ok con lo retornado 
            return Ok(fosil);
        }

        //metodo para crear un fosil en donde se envia como el parametro de entrada el fosil 
        //se asocia al verbo POST
        [HttpPost]
        public IHttpActionResult CrearFosil(Fosil fosil)
        {
            if (!ModelState.IsValid)
                //si es invalido el modelo se envia un BadRequest()
                return BadRequest(ModelState);
            //si es valido se agrega a la lista el fosil 
            bd.Fosiles.Add(fosil);
            //se guarda los cambios
            bd.SaveChanges();
            return CreatedAtRoute("DefaultApi", new {id = fosil.ID}, fosil);
        }

        //Metodo para actualizar el fosil, se envia como parametros de entrada el id del fosil que se quiere actualizar y 
        // el fosil con los datos actualizados
        // se asocia al verbo PUT

        [HttpPut]
        public IHttpActionResult ActualizarFosil(int id, Fosil fosil)
        {
            // Primero se valida el modelo
            if (!ModelState.IsValid)
                return BadRequest(ModelState);
            //si el id no corresponde al id del fosil se envia un badRequest()
            if (id != fosil.ID)
                return BadRequest();
            //Se cambia el estado del fosil 
            bd.Entry(fosil).State = EntityState.Modified;
            //se guarda los cambios
            bd.SaveChanges();
            return StatusCode(HttpStatusCode.NoContent);
        }

        // Metodo para borrar un Fosil donde el parametro de entrada es el id del fosil que se quiere eliminar
        //se asocia al verbo delete

        [HttpDelete]
        public IHttpActionResult BorrarFosil(int id)
        {
            //se busca el fosil por el id
            var fosil = bd.Fosiles.Find(id);
            //si el fosil no existe en la lista se envia un NotFound()
            if (fosil == null)
                return NotFound();
            //en caso contrario se elimiane el fosil usando le metodo Remove()
            bd.Fosiles.Remove(fosil);
            //se guarda los cambios
            bd.SaveChanges();
            //se retorna un ok
            return Ok(fosil);
        }

    }
}
