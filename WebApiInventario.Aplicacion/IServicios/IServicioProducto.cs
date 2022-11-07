using System;
using System.Collections.Generic;
using System.Text;
using WebApiInventario.Dominio.DTOs;
using WebApiInventario.Dominio.Entidades;

namespace WebApiInventario.Aplicacion.IServicios
{
    public interface IServicioProducto
    {
        void EliminarProducto(int id);
        IEnumerable<DtoProducto> ConsultarProductos();
        DtoProducto ConsultarProducto(int id);
        void GuardarProducto(DtoProducto dtoProducto);

        void EditarProducto(DtoProducto dtoProducto);
    }
}
