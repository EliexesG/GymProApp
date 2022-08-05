using GymPro.Capa.Entidades.Implementaciones;
using System.Collections.Generic;

namespace GymPro.Capa.Logica.BLL.Interfaces
{
    public interface IDiaEntrenamientoBLL
    {
        void EliminarDiaEntrenamiento(DiaEntrenamiento pDiaEntrenamiento);
        void InsertarDiaEntrenamiento(DiaEntrenamiento pDiaEntrenamiento);
        List<DiaEntrenamiento> ObtenerDiaEntrenamientoCodigoEntrenamiento(int pCodigoEntrenamiento);
        List<DiaEntrenamiento> ObtenerDiaEntrenamientoTodos();
    }
}