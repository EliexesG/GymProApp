using GymPro.Capa.Entidades.Implementaciones;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GymPro.Capa.Datos
{/// <summary>
/// Todas las operaciones para manejar los ejercicios a nivel de persitencia
/// </summary>
    public class EjercicioDAL : IEjercicioDAL
    {

        private static EjercicioDAL Instancia;

        /// <summary>
        /// Retorna instancia de tipo EjercicioDAL
        /// </summary>
        /// <returns></returns>
        public static EjercicioDAL GetInstance()
        {
            if(Instancia == null)
            {
                Instancia = new EjercicioDAL();
            }

            return Instancia;
        }

        /// <summary>
        /// Inserta un Ejercicio en la base de datos
        /// </summary>
        /// <param name="pEjercicio"></param>
        public void InsertarEjercicio(Ejercicio pEjercicio)
        {
         
        }

        /// <summary>
        /// Actualiza un Ejercicio en la base de datos
        /// </summary>
        /// <param name="pEjercicio"></param>
        public void ActualizarEjercicio(Ejercicio pEjercicio)
        {

        }

        /// <summary>
        /// Retorna todos los Ejercicios en la base de datos
        /// </summary>
        /// <returns></returns>
        public List<Ejercicio> SeleccionarTodosEjercicios()
        {
            return null;
            // Seleccione todos los que tengan el campo estado en true
        }

        /// <summary>
        /// Retorna un Ejercicio de la base por id
        /// </summary>
        /// <param name="pId"></param>
        /// <returns></returns>
        public Ejercicio SeleccionarEjercicioPorId(int pId)
        {
            return default;
        }

        /// <summary>
        /// Elimina un Ejercicio de la base por id
        /// </summary>
        /// <param name="pId"></param>
        public void EliminarEjercicioPorId(int pId)
        {
            // No va a hacer un delete sino que va a hacer un UPDATE al campo Activo
        }

    }
}
