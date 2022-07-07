using GymPro.Capa.Entidades.Implementaciones;
using System.Collections.Generic;

namespace GymPro.Capa.Datos.Interfaces
{
    public interface ITipoEjercicioDAL
    {
        void ActualizarTipoEjercicio(TipoEjercicio pTipoEjercicio);
        void EliminarTipoEjercicioPorID(int pId);
        void InsertarTipoEjercicio(TipoEjercicio pTipoEjercicio);
        TipoEjercicio SeleccionarTipoEjercicioPorID(int pId);
        IList<TipoEjercicio> SeleccionarTodosTiposEjercicio();
    }
}