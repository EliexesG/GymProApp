using GymPro.Capa.Entidades.Implementaciones;
using System.Collections.Generic;

namespace GymPro.Capa.Datos.Interfaces
{
    public interface IDiaEntrenamientoDAL
    {
        void EliminarDiaDeEntrenamiento(DiaEntrenamiento pDia);
        void InsertarDiaEnEntrenamiento(DiaEntrenamiento pDia);
        List<DiaEntrenamiento> SeleccionarDiasDeEntrenamientoPorID(int pId);
        List<DiaEntrenamiento> SeleccionarTodosDiasDeEntrenamiento();
    }
}