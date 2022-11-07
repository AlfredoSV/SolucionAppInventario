using System;
using System.Collections.Generic;
using System.Text;

namespace WebApiInventario.Dominio.DTOs
{
    public class DtoProducto
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public int RestriccionEdad { get; set; }
        public string Compania { get; set; }
        public string Precio { get; set; }
        public string Imagen { get; set; }
    }
}
