using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AppInventario.Models
{
    public class ProductoModel
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Favor de ingresar un nombre")]
        [MaxLength(50, ErrorMessage = "Favor de ingresar un nombre con una cantidad menor o igual a 50 carácteres")]
        public string Nombre { get; set; }

        [MaxLength(100, ErrorMessage = "Favor de ingresar una descripción con una cantidad menor o igual a 100 carácteres")]
        public string Descripcion { get; set; }
        
        [Range(0,100,ErrorMessage = "Favor de ingresar una edad valida que se encuentre entre el rango 0 a 100")]
       
        public int? RestriccionEdad { get; set; }
        [Required(ErrorMessage = "Favor de ingresar una compañia")]
        [MaxLength(50, ErrorMessage = "Favor de ingresar un nombre de compañia con una cantidad menor o igual a 50 carácteres")]
        public string Compania { get; set; }
       
        [Required(ErrorMessage = "Favor de ingresar una precio valido")]
        [Range(1.00, 1000, ErrorMessage = "Favor de ingresar un precio valida que se encuentre entre el rango 1  a 1000")]

        public string Precio { get; set; }
        public IFormFile Imagen { get; set; }
    }
}
