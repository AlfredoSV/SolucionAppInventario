using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Globalization;
using System.Text;
using WebApiInventario.Dominio.DTOs;
using WebApiInventario.Dominio.ManejoErrores;

namespace WebApiInventario.Dominio.Entidades
{
    public class Producto
    {

        [Key]
        public int  Id { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public int RestriccionEdad { get; set; }
        public string Compania { get; set; }
        public Decimal Precio { get; set; }
        public string Imagen { get; set; }

        public Producto() { }
        public  static Producto CrearProducto(DtoProducto dtoProducto)
        {
            return new Producto(dtoProducto.Id, dtoProducto.Nombre, dtoProducto
                .Descripcion, dtoProducto.RestriccionEdad, dtoProducto.Compania, decimal.Parse(dtoProducto.Precio, new CultureInfo("es-MX")), dtoProducto.Imagen);
        }

        private Producto(int id, string nombre, string descripcion, int restriccionEdad, 
            string compania, decimal precio, string imagen)
        {
            Id = id;
            if (nombre.Length > 50)
                throw new ExcepcionComun("Nombre incorrecto", "El nombre no puede tener una longitud mayor a 50 caracteres");
            Nombre = nombre;
            if(descripcion != null)
                if (descripcion.Length > 100)
                    throw new ExcepcionComun("Descripción incorrecto", "El descripción no puede tener una longitud mayor a 100 caracteres");

            Descripcion = descripcion;

            if (restriccionEdad<0 || restriccionEdad >100)
                throw new ExcepcionComun("Restricción edad incorrecto", "La restricción de edad debe encontrarse entre el rango de 0 a 100");

            RestriccionEdad = restriccionEdad;
            if (compania.Length > 50)
                throw new ExcepcionComun("compania incorrecto", "La compania no puede tener una longitud mayor a 50 caracteres");

            Compania = compania;

            if (precio < 1 || precio > 1000)
                throw new ExcepcionComun("Precio edad incorrecto", "El Precio debe encontrarse entre el rango de 1 a 1000");

            Precio = precio;
            Imagen = imagen.Equals("") ? string.Empty :  imagen;
        }
    }
}
