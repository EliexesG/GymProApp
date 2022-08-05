using GymPro.Capa.Entidades.Implementaciones;
using System.Collections.Generic;

namespace GymPro.Capa.Logica.BLL.Interfaces
{
    public interface IServicioBLL
    {
        double CalcularCostoServicio(Servicio pServicio);
        Servicio ObtenerServicioId(int pCodigo);
        List<Servicio> ObtenerServicioTodos();
    }
}