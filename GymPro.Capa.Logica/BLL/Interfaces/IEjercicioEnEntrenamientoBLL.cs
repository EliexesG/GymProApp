using GymPro.Capa.Entidades.Implementaciones;
using System.Collections.Generic;

namespace GymPro.Capa.Logica.BLL.Interfaces
{
    public interface IEjercicioEnEntrenamientoBLL
    {
        void EliminarEjercicioEnEntrenamiento(int pCodigoEntrenamiento, int pCodigoEjercicio);
        void InsertarEjercicioEnEntrenamiento(EjercicioEnEntrenamiento pEjercicioEnEntrenamiento);
        void ModificarEjercicioEnEntrenamiento(EjercicioEnEntrenamiento pEjercicioEnEntrenamiento);
        List<EjercicioEnEntrenamiento> ObtenerEjercicioEnEntrenamientoCodigoEjercicio(int pCodigoEjercicio);
        List<EjercicioEnEntrenamiento> ObtenerEjercicioEnEntrenamientoCodigoEntrenamiento(int pCodigoEntrenamiento);
        EjercicioEnEntrenamiento ObtenerEjercicioEnEntrenamientoId(int pCodigoEntrenamiento, int pCodigoEjercicio);
        List<EjercicioEnEntrenamiento> ObtenerEjercicioEnEntrenamientoTodos();
    }
}