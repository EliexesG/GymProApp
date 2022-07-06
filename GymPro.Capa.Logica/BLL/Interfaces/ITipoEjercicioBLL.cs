using GymPro.Capa.Entidades.Implementaciones;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GymPro.Capa.Logica.BLL.Interfaces
{
    public interface ITipoEjercicioBLL
    {
        void ActualizarTipoEjercicio(TipoEjercicio pTipoEjercicio);
        void EliminarTipoEjercicioPorId(int id);
        void InsertarTipoEjercicio(TipoEjercicio pTipoEjercicio);
        TipoEjercicio SeleccionarTipoEjercicioPorId(int id);
        IList<TipoEjercicio> SeleccionarTodosTiposEjercicio();
        TipoEjercicio SeleccionarTipoEjercicioPorIdEjercicio(int pId);
    }
}
