using GymPro.Capa.Entidades.Implementaciones;
using System.Collections.Generic;

namespace GymPro.Capa.Datos
{
    public interface IEntrenamientoDAL
    {
        void ActualizarEntrenamiento(Entrenamiento pEntrenamiento);
        void EliminarDiaEntrenamiento(int idEntrenamiento, Dia dia);
        void EliminarEntrenamientoPorId(int id);
        void InsertarDiaEntrenamiento(int idEntrenamiento, Dia dia);
        void InsertarEntrenamientoUsuario(Entrenamiento pEntrenamineto, string id);
        Entrenamiento ObtenerEntrenamientoPorId(int id);
        List<Entrenamiento> ObtenerTodosEntrenamientosUsuario(string id);
        List<Dia> ObtenerDiasEntrenamientoPorId(int pId)
    }
}