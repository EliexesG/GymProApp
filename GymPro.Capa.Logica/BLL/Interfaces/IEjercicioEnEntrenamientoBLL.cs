using GymPro.Capa.Entidades.Implementaciones;
using System.Collections.Generic;

namespace GymPro.Capa.Logica.BLL.Interfaces
{
    interface IEjercicioEnEntrenamientoBLL
    {
        void ActualizarEjercicioEnEntrenamiento(EjercicioEnEntrenamiento pEjercicio);
        void EliminarEjercicioEnEntrenamientoID(int pIdEntrenamiento, int idEjercicio);
        void InsertarEjercicioEnEntrenamiento(EjercicioEnEntrenamiento pEjercicio);
        List<EjercicioEnEntrenamiento> ObtenerEjerciciosEnEntrenamientosPorIDEntrenamiento(int pId);
        List<EjercicioEnEntrenamiento> ObtenerTodosEjerciciosDeEntrenamientos();
    }
}