using GymPro.Capa.Entidades.Implementaciones;
using System.Collections.Generic;

namespace GymPro.Capa.Logica.BLL.Interfaces
{
    interface IEjercicioBLL
    {
        void ActualizarEjercicio(Ejercicio pEjercicio);
        void EliminarEjercicioPorId(int pId);
        void InsertarEjercicio(Ejercicio pEjercicio);
        Ejercicio SeleccionarEjercicioPorId(int pId);
        List<Ejercicio> SeleccionarTodosEjercicios();
    }
}