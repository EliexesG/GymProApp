using GymPro.Capa.Entidades.Implementaciones;
using System.Collections.Generic;

namespace GymPro.Capa.Logica.BLL.Interfaces
{
    public interface IEjercicioBLL
    {
        void EliminarEjercicio(int pCodigo);
        void InsertarEjercicio(Ejercicio pEjercicio);
        void ModificarEjercicio(Ejercicio pEjercicio);
        List<Ejercicio> ObtenerEjercicioCodigoTipo(int pCodigoTipo);
        Ejercicio ObtenerEjercicioId(int pCodigo);
        List<Ejercicio> ObtenerEjercicioTodos();
    }
}