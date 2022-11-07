using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.IO;
using System.Text;


namespace AppInventario.Models
{
    public class Producto
    {

        public int  Id { get; set; }
        
        public string Nombre { get; set; }

        public string Descripcion { get; set; }

        public int RestriccionEdad { get; set; }
       
        public string Compania { get; set; }
        
        public string Precio { get; set; }
        
        public string Imagen { get; set; }

        public Producto() { }
        public static Producto CrearProducto(ProductoModel dtoProducto)
        {
            string imgab64 = string.Empty;
            if(dtoProducto.Imagen != null)
            {
                if (dtoProducto.Imagen.Length > 0)
                {
                    using (var ms = new MemoryStream())
                    {
                        dtoProducto.Imagen.CopyTo(ms);
                        var fileBytes = ms.ToArray();
                        imgab64 = Convert.ToBase64String(fileBytes);

                    }
                }
            }
            
            return new Producto(dtoProducto.Id, dtoProducto.Nombre, dtoProducto
                .Descripcion, dtoProducto.RestriccionEdad.Value, dtoProducto.Compania, dtoProducto.Precio, imgab64);
        }

        private Producto(int id, string nombre, string descripcion, int restriccionEdad,
            string compania, string precio, string imagen)
        {
            Id = id;
            Nombre = nombre;
            Descripcion = descripcion;
            RestriccionEdad =restriccionEdad;
            Compania = compania;
            Precio = precio;
            Imagen = imagen;
        }


    }
}
