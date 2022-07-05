using GymPro.Capa.Entidades.Implementaciones;
using System.Collections.Generic;

namespace GymPro.Capa.Datos
{
    public interface IEjercicioEnEntrenamientoDAL
    {
        void ActualizarEjercicioEnEntrenamiento(int idEntrenamiento, EjercicioEnEntrenamiento pEjercicio);
        void EliminarEjercicioEnEntrenamiento(int idEntrenamiento, int idEjercicio);
        void InsertarEjercicioEnEntrenamiento(int idEntrenamiento, EjercicioEnEntrenamiento pEjercicio);
        List<EjercicioEnEntrenamiento> ObtenerTodosEjerciciosPorEntrenamiento(int idEntrenamiento);
    }
}