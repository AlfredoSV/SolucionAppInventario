using System;
using System.Collections.Generic;
using System.Text;
using WebApiInventario.Dominio.Entidades;

namespace WebApiInventario.Dominio.IRepositorios
{
    public interface IRepositorioProductos
    {
        void Eliminar(int id);

        void Crear(Producto producto);

        void Actualizar(Producto producto);

        IEnumerable<Producto> Listar();

        Producto ListarPorId(int id);


    }
}
