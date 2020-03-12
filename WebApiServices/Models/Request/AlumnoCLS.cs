using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApiServices.Models.Request
{
    public class AlumnoCLS
    {  //Para mandar estos datos creamos esta clase, recibira los parametros que estamos metiendo en la base de datos
        public int IdAlumno { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public int Edad { get; set; }
    }
}