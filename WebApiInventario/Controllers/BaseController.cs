using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApiInventario.Dominio.ManejoErrores;

namespace WebApiInventario.Controllers
{
    public class BaseController : Controller
    {
        protected ActionResult RegresarRespuestaHttpCorrecta()
        {
            return Ok();
        }

        protected ActionResult RegresarRespuestaIncorrectaComun(string controlador, ExcepcionComun e)
        {

            return BadRequest(new { Detalle = e.Detalle, Controlador = controlador });
        }


        protected ActionResult RegresarRespuestaIncorrectaNoControlada(string controlador, Exception e)
        {
            return StatusCode(StatusCodes.Status500InternalServerError, new { Detalle = e.Message, Controlador = controlador });

        }
    }
}
