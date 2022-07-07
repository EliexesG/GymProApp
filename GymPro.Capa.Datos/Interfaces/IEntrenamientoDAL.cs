using GymPro.Capa.Entidades.Implementaciones;
using System.Collections.Generic;

namespace GymPro.Capa.Datos.Interfaces
{
    public interface IEntrenamientoDAL
    {
        void ActualizarEntrenamiento(Entrenamiento pEntrenamiento);
        void EliminarEntrenamientoPorID(int pId);
        void InsertarEntrenamiento(Entrenamiento pEntrenamiento);
        Entrenamiento SeleccionarEntrenamientoPorID(int pId);
        List<Entrenamiento> SeleccionarEntrenamientosPorIDUsuario(string pIdUsuario);
        List<Entrenamiento> SeleccionarTodosEntrenamientos();
    }
}