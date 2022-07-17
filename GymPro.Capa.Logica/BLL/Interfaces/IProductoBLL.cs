using GymPro.Capa.Entidades.Implementaciones;
using System.Collections.Generic;

namespace GymPro.Capa.Logica.BLL.Interfaces
{
    public interface IProductoBLL
    {
        Servicio SeleccionarProductoPorID(int pId);
        List<Servicio> SeleccionarTodosProductos();
    }
}