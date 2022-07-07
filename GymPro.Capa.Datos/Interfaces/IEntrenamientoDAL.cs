using GymPro.Capa.Entidades.Implementaciones;
using System.Collections.Generic;

namespace GymPro.Capa.Datos
{
    public interface IEntrenamientoDAL
    {
        void InsertarEntrenamientoDeUsuario(string pId, Entrenamiento pEntrenamiento);
        void EliminarEntrenamientoPorID(int pId);
        void ActualizarEntrenamiento(Entrenamiento pEntrenamiento);
        Entrenamiento ObtenerEntrenamientoPorID(int pId);
        List<Entrenamiento> ObtenerTodosEntrenamientos();
        List<Entrenamiento> ObtenerEntrenamientosIdUsuario(string pId);
        void InsertarDiaEnEntrenamiento(int pId, Dia pDia);
        void EliminarDiaDeEntrenamiento(int pId, Dia pDia);
        List<Dia> ObtenerDiasDeEntrenamientoPorID(int pId);
    }
}