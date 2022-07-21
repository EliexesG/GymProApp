using GymPro.Capa.Entidades.Implementaciones;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GymPro.Capa.Datos.Interfaces
{
    public interface ITipoEjercicioDAL
    {
        void InsertarTipoEjercicio(TipoEjercicio pTipoEjercicio);
        void ModificarTipoEjercicio(TipoEjercicio pTipoEjercicio);
        void EliminarTipoEjercicio(int pCodigo);
        List<TipoEjercicio> ObtenerTipoEjercicioTodos();
        TipoEjercicio ObtenerTipoEjercicioId(int pCodigo);
    }
}
