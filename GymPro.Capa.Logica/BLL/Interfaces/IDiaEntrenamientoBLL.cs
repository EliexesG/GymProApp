using GymPro.Capa.Entidades.Implementaciones;
using System.Collections.Generic;

namespace GymPro.Capa.Logica.BLL.Interfaces
{
    interface IDiaEntrenamientoBLL
    {
        void EliminarDiaDeEntrenamiento(DiaEntrenamiento pDia);
        void InsertarDiaEnEntrenamiento(DiaEntrenamiento pDia);
        List<DiaEntrenamiento> SeleccionarDiasDeEntrenamientoPorID(int pId);
        List<DiaEntrenamiento> SeleccionarTodosDiasDeEntrenamiento();
    }
}