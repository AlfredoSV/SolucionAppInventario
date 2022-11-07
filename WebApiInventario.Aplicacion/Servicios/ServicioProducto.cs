using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using WebApiInventario.Aplicacion.IServicios;
using WebApiInventario.Dominio.DTOs;
using WebApiInventario.Dominio.Entidades;
using WebApiInventario.Dominio.IRepositorios;

namespace WebApiInventario.Aplicacion.Servicios
{
    public class ServicioProducto : IServicioProducto
    {
        private readonly IRepositorioProductos _RepositorioProductos;
        public ServicioProducto(IRepositorioProductos repositorioProductos)
        {
            this._RepositorioProductos = repositorioProductos;
        }

        public IEnumerable<DtoProducto> ConsultarProductos()
        {
            var productos = this._RepositorioProductos.Listar().ToList();
            List<DtoProducto> prodRes = new List<DtoProducto>();

            productos.ForEach(p => prodRes.Add(new DtoProducto()
            {
                Id = p.Id,
                Nombre = p.Nombre,
                Descripcion = p.Descripcion,
                RestriccionEdad = p.RestriccionEdad,
                Compania = p.Compania,
                Precio =  p.Precio.ToString("C", CultureInfo.GetCultureInfo("en-MX")),
                Imagen = p.Imagen
            })); ;

            return prodRes;
        }

        public DtoProducto ConsultarProducto(int id)
        {
            var producto = this._RepositorioProductos.ListarPorId(id);
            return new DtoProducto()
            {
                Id = producto.Id,
                Nombre = producto.Nombre,
                Descripcion = producto.Descripcion,
                RestriccionEdad = producto.RestriccionEdad,
                Compania = producto.Compania,
                Precio = producto.Precio.ToString("N3", CultureInfo.CreateSpecificCulture("es-MX").NumberFormat),
                Imagen = producto.Imagen
            };
        }

        public void EliminarProducto(int id)
        {
            this._RepositorioProductos.Eliminar(id);
        }

        public void GuardarProducto(DtoProducto dtoProducto)
        {
            dtoProducto.Imagen = "data:image/png;base64," + dtoProducto.Imagen;
            var producto = Producto.CrearProducto(dtoProducto);
            this._RepositorioProductos.Crear(producto);
        }

        public void EditarProducto(DtoProducto dtoProducto)
        {
            var productoConsulta  = this._RepositorioProductos.ListarPorId(dtoProducto.Id);
            if(!productoConsulta.Imagen.Equals(string.Empty) && dtoProducto.Imagen.Equals(string.Empty))
            {
                dtoProducto.Imagen = productoConsulta.Imagen;
            }
            else
            {
                dtoProducto.Imagen = "data:image/png;base64," + dtoProducto.Imagen;
            }
            var producto = Producto.CrearProducto(dtoProducto);
            this._RepositorioProductos.Actualizar(producto);
        }
    }
}
