using GymPro.Capa.Entidades.Implementaciones;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GymPro.Capa.Logica.BLL.Interfaces
{
    interface IEjercicioBLL
    {
        void ActualizarEjercicio(Ejercicio pEjercicio);
        void EliminarEjercicioPorId(int id);
        void InsertarEjercicio(Ejercicio pEjercicio);
        Ejercicio SeleccionarEjercicioPorId(int id);
        List<Ejercicio> SeleccionarTodosEjercicios();
    }
}
