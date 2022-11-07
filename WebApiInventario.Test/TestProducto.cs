using System;
using WebApiInventario.Aplicacion.IServicios;
using WebApiInventario.Aplicacion.Servicios;
using WebApiInventario.Dominio.DTOs;
using WebApiInventario.Dominio.IRepositorios;
using WebApiInventario.Dominio.ManejoErrores;
using Xunit;
using Moq;
using WebApiInventario.Dominio.Entidades;

namespace WebApiInventario.Test
{
    public class TestProducto
    {
 

        [Fact]
        public void CrearNuevoProducto_NombreLongitudMayorACicuenta_ExcepcionComun()
        {
            

            var dtoProducto = new DtoProducto() { Id = 1, Compania = "Purueba",
                Descripcion = "Prueba", Imagen = string.Empty,
                Nombre = "sdsdsdsdsdsdsdsdsdsdsdsdsdsdsdsdsdsdsdsdsdsdsdsdsdsdsdsdsdsdsdsd",
                Precio = 78.8.ToString(), RestriccionEdad = 87
            };

            Assert.Throws<ExcepcionComun>(() => Producto.CrearProducto(dtoProducto));
            
          

        }

        [Fact]
        public void CrearNuevoProducto_DescripcionLongitudMayorACicuenta_ExcepcionComun()
        {


            var dtoProducto = new DtoProducto()
            {
                Id = 1,
                Compania = "Purueba",
                Descripcion = "sdsdsdsdsdsdsdsdsdsdsdsdsdsdsdsdsdsdsdsdsdsdsdsdsdsdsdsdsdsdsdsdsdsdsdsdsdsdsdsdsdsdsdsdsdsdsdsdsdsdsdsdsdsdsdsdsdsdsdsdsdsdsdsd",
                Imagen = string.Empty,
                Nombre = "kk",
                Precio = 78.8.ToString(),
                RestriccionEdad = 87
            };

            Assert.Throws<ExcepcionComun>(() => Producto.CrearProducto(dtoProducto));



        }

        [Fact]
        public void CrearNuevoProducto_EdadFuraDeRango_ExcepcionComun()
        {


            var dtoProducto = new DtoProducto()
            {
                Id = 1,
                Compania = "Purueba",
                Descripcion = "j",
                Imagen = string.Empty,
                Nombre = "kk",
                Precio = 78.8.ToString(),
                RestriccionEdad = 102
            };

            Assert.Throws<ExcepcionComun>(() => Producto.CrearProducto(dtoProducto));



        }

        [Fact]
        public void CrearNuevoProducto_CompaniaLongitudIncorrecta_ExcepcionComun()
        {


            var dtoProducto = new DtoProducto()
            {
                Id = 1,
                Compania = "Puruebakjllllllllllllllllllllllllllllllllllllllllllllllllllllllllllllllllllll",
                Descripcion = "j",
                Imagen = string.Empty,
                Nombre = "kk",
                Precio = 78.8.ToString(),
                RestriccionEdad = 100
            };

            Assert.Throws<ExcepcionComun>(() => Producto.CrearProducto(dtoProducto));



        }


        [Fact]
        public void CrearNuevoProducto_PrecioFuraDeRango_ExcepcionComun()
        {


            var dtoProducto = new DtoProducto()
            {
                Id = 1,
                Compania = "Purueba",
                Descripcion = "j",
                Imagen = string.Empty,
                Nombre = "kk",
                Precio = 10111.ToString(),
                RestriccionEdad = 100
            };

            Assert.Throws<ExcepcionComun>(() => Producto.CrearProducto(dtoProducto));



        }

    }
}
