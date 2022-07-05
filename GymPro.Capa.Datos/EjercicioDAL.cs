using GymPro.Capa.Entidades.Clases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GymPro.Capa.Datos
{/// <summary>
/// Todas las operaciones para manejar los ejercicios a nivel de persitencia
/// </summary>
    public class EjercicioDAL
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="pEjercicio"></param>
        public void InsertarEjercicio(Ejercicio pEjercicio)
        {
         
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="pEjercicio"></param>
        public void ActualizarEjercicio(Ejercicio pEjercicio)
        {

        }
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public IEnumerable<Ejercicio> SeleccionarTodosEjercicios()
        {
            return null;
            // Seleccione todos los que tengan el campo estado en true
        }

        public Ejercicio SeleccionarPorId(int id)
        {
            return default;
        }

        public void EliminarEjercicio(int id)
        {
            // No va a hacer un delete sino que va a hacer un UPDATE al campo Activo
        }

    }
}
