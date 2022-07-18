using GymPro.Capa.Entidades.Implementaciones;
using System.Collections.Generic;

namespace GymPro.Capa.Logica.BLL.Interfaces
{
    public interface IServicioBLL
    {
        Servicio ObtenerServicioId(int pCodigo);
        List<Servicio> ObtenerServicioTodos();
    }
}