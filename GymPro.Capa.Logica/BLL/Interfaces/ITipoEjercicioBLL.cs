using GymPro.Capa.Entidades.Implementaciones;
using System.Collections.Generic;

namespace GymPro.Capa.Logica.BLL.Interfaces
{
    public interface ITipoEjercicioBLL
    {
        void EliminarTipoEjercicio(int pCodigo);
        void InsertarTipoEjercicio(TipoEjercicio pTipoEjercicio);
        void ModificarTipoEjercicio(TipoEjercicio pTipoEjercicio);
        TipoEjercicio ObtenerTipoEjercicioId(int pCodigo);
        List<TipoEjercicio> ObtenerTipoEjercicioTodos();
    }
}