using GymPro.Capa.Entidades.Implementaciones;
using System.Collections.Generic;

namespace GymPro.Capa.Datos.Interfaces
{
    public interface IProductoDAL
    {
        Producto SeleccionarProductoPorID(int pId);
        List<Producto> SeleccionarTodosProductos();
    }
}