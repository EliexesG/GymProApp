using GymPro.Capa.Entidades.Implementaciones;
using System.Collections.Generic;

namespace GymPro.Capa.Datos.Interfaces
{
    public interface IProductoDAL
    {
        Servicio SeleccionarProductoPorID(int pId);
        List<Servicio> SeleccionarTodosProductos();
    }
}