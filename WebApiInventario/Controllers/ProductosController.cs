using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApiInventario.Aplicacion.IServicios;
using WebApiInventario.Dominio.DTOs;
using WebApiInventario.Dominio.Entidades;
using WebApiInventario.Dominio.ManejoErrores;

namespace WebApiInventario.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductosController : BaseController
    {

        private readonly IServicioProducto _ServicioProducto;
        public ProductosController(IServicioProducto servicioProducto)
        {
            this._ServicioProducto = servicioProducto;
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            
            try
            {
                this._ServicioProducto.EliminarProducto(id);
                return Ok();
            }
            catch (ExcepcionComun e)
            {

                return RegresarRespuestaIncorrectaComun("Eliminar", e);
            }
            catch (Exception e)
            {
                return RegresarRespuestaIncorrectaNoControlada("Eliminar", e);
            }
        }

        [HttpGet]
        public IActionResult Get()
        {
            try
            {
                return Json(this._ServicioProducto.ConsultarProductos());
            }
            catch (ExcepcionComun e)
            {

                return RegresarRespuestaIncorrectaComun("Get", e);
            }
            catch (Exception e)
            {
                return RegresarRespuestaIncorrectaNoControlada("Get", e);
            }
            
        }
        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            try
            {
                return Json(this._ServicioProducto.ConsultarProducto(id));
            }
            catch (ExcepcionComun e)
            {

                return RegresarRespuestaIncorrectaComun("GetById", e);
            }
            catch (Exception e)
            {
                return RegresarRespuestaIncorrectaNoControlada("GetById", e);
            }

        }

        [HttpPost]
        public IActionResult Post([FromBody] DtoProducto dtoProducto)
        {
            

            try
            {
                this._ServicioProducto.GuardarProducto(dtoProducto);
                return Ok();
            }
            catch (ExcepcionComun e)
            {

                return RegresarRespuestaIncorrectaComun("Post", e);
            }
            catch (Exception e)
            {
                return RegresarRespuestaIncorrectaNoControlada("Post", e);
            }
        }

        [HttpPut]

        public IActionResult Put([FromBody] DtoProducto dtoProducto)
        {

            try
            {
                this._ServicioProducto.EditarProducto(dtoProducto);
                return Ok();
            }
            catch (ExcepcionComun e)
            {

                return RegresarRespuestaIncorrectaComun("Put", e);
            }
            catch (Exception e)
            {
                return RegresarRespuestaIncorrectaNoControlada("Put", e);
            }
        }
    }
}
