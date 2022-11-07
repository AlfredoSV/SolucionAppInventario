using System;
using System.Collections.Generic;
using System.Text;
using WebApiInventario.Dominio.IRepositorios;
using WebApiInventario.Dominio.Entidades;
using WebApiInventario.Infraestructura.Data;
using System.Linq;
using WebApiInventario.Dominio.ManejoErrores;

namespace WebApiInventario.Infraestructura.Repositorios
{
    public class RepositorioProductos : IRepositorioProductos
    {

        private readonly InventarioDbContext _InventarioDbContext;
        public RepositorioProductos(InventarioDbContext inventarioDbContext)
        {
            this._InventarioDbContext = inventarioDbContext;                                                                                                                                                                                                                                                                                                                                                                                  

        }
        public void Crear(Producto producto)
        {
            try
            {
                this._InventarioDbContext.Productos.Add(producto);
                this._InventarioDbContext.SaveChanges();
            }
            catch (Exception e)
            {

                throw new ExcepcionComun("RepositorioProductos-Crear", e.Message);
            }
            
        }

        public void Eliminar(int id)
        {
            try
            {
                var producto = this._InventarioDbContext.Productos.FirstOrDefault(p => p.Id == id);
                this._InventarioDbContext.Productos.Remove(producto);
                this._InventarioDbContext.SaveChanges();
            }
            catch (Exception e)
            {

                throw new ExcepcionComun("RepositorioProductos-Eliminar", e.Message);
            }
          
        }

        public IEnumerable<Producto> Listar()
        {
            try
            {
                return this._InventarioDbContext.Productos.ToList();
            }
            catch (Exception e)
            {

                throw new ExcepcionComun("RepositorioProductos-Listar", e.Message);
            }
            
        }

        public Producto ListarPorId(int id)
        {
            try
            {
                return this._InventarioDbContext.Productos.FirstOrDefault(x => x.Id == id);
            }
            catch (Exception e)
            {

                throw new ExcepcionComun("RepositorioProductos-ListarPorId", e.Message);
            }
            
        }

        public void Actualizar(Producto producto)
        {
            try
            {
                var productoEd = this._InventarioDbContext.Productos.FirstOrDefault(p => p.Id == producto.Id);
                productoEd.Imagen = producto.Imagen;
                productoEd.Nombre = producto.Nombre;
                productoEd.Precio = producto.Precio;
                productoEd.RestriccionEdad = producto.RestriccionEdad;
                productoEd.Descripcion = producto.Descripcion;
                productoEd.Compania = producto.Compania;

                this._InventarioDbContext.SaveChanges();
            }
            catch (Exception e)
            {

                throw new ExcepcionComun("RepositorioProductos-Actualizar", e.Message);
            }
            
        }
    }
}
