using GymPro.Capa.Entidades.Implementaciones;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GymPro.Capa.Datos
{
    public interface IEjercicioDAL
    {
        void ActualizarEjercicio(Ejercicio pEjercicio);
        void EliminarEjercicioPorId(int id);
        void InsertarEjercicio(Ejercicio pEjercicio);
        Ejercicio SeleccionarEjercicioPorId(int id);
        IList<Ejercicio> SeleccionarTodosEjercicios();
    }
}
