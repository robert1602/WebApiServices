using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace WebApiServices.Controllers
{
    public class AlumnoController : ApiController
    {
        [HttpPost]
        public IHttpActionResult Agregrar(Models.Request.AlumnoCLS model)//recibo el modelo AlumnoCLS en el controlador
        {
            using (Models.PERSONAS_3Entities db = new Models.PERSONAS_3Entities())
            {
                var oAlumnos = new Models.Alumno();
                //oAlumnos.idAlumno = oAlumnos.idAlumno;
                oAlumnos.nombre = model.Nombre;//model va a tener los atributos de esta parte
                oAlumnos.apellido = model.Apellido;
                oAlumnos.edad = model.Edad;
                db.Alumno.Add(oAlumnos);
                db.SaveChanges();

            }
            return Ok("Exitoso");
        }

    }
}
