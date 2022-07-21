using GymPro.Capa.Entidades.Implementaciones;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GymPro.Capa.Datos.Interfaces
{
    public interface IEjercicioDAL
    {
        void InsertarEjercicio(Ejercicio pEjercicio);
        void ModificarEjercicio(Ejercicio pEjercicio);
        void EliminarEjercicio(int pCodigo);
        List<Ejercicio> ObtenerEjercicioTodos();
        Ejercicio ObtenerEjercicioId(int pCodigo);
        List<Ejercicio> ObtenerEjercicioCodigoTipo(int pCodigoTipo);
    }
}
