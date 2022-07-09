using GymPro.Capa.Entidades.Implementaciones;
using System.Collections.Generic;

namespace GymPro.Capa.Logica.BLL.Interfaces
{
    public interface IProductoBLL
    {
        Producto SeleccionarProductoPorID(int pId);
        List<Producto> SeleccionarTodosProductos();
    }
}