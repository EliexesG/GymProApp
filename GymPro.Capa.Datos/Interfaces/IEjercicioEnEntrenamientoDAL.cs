using GymPro.Capa.Entidades.Implementaciones;
using System.Collections.Generic;

namespace GymPro.Capa.Datos.Interfaces
{
    public interface IEjercicioEnEntrenamientoDAL
    {
        void ActualizarEjercicioEnEntrenamiento(EjercicioEnEntrenamiento pEjercicio);
        void EliminarEjercicioEnEntrenamientoID(int pIdEntrenamiento, int idEjercicio);
        void InsertarEjercicioEnEntrenamiento(EjercicioEnEntrenamiento pEjercicio);
        List<EjercicioEnEntrenamiento> ObtenerEjerciciosEnEntrenamientosPorIDEntrenamiento(int pId);
        List<EjercicioEnEntrenamiento> ObtenerTodosEjerciciosDeEntrenamientos();
    }
}