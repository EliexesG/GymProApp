using GymPro.Capa.Entidades.Implementaciones;
using System.Collections.Generic;

namespace GymPro.Capa.Datos
{
    public interface ITipoEjercicioDAL
    {
        void ActualizarTipoEjercicio(TipoEjercicio pTipoEjercicio);
        void EliminarTipoEjercicioPorId(int id);
        void InsertarTipoEjercicio(TipoEjercicio pTipoEjercicio);
        Ejercicio SeleccionarTipoEjercicioPorId(int id);
        IList<TipoEjercicio> SeleccionarTodosTiposEjercicio();
    }
}