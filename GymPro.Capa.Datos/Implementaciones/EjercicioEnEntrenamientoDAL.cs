using GymPro.Capa.Entidades.Implementaciones;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GymPro.Capa.Datos
{
    public class EjercicioEnEntrenamientoDAL : IEjercicioEnEntrenamientoDAL
    {

        private static EjercicioEnEntrenamientoDAL Instancia;

        /// <summary>
        /// Retorna instancia de tipo EjercicioEnEntrenamiento
        /// </summary>
        /// <returns></returns>
        public static EjercicioEnEntrenamientoDAL GetInstance()
        {
            if (Instancia == null)
            {
                Instancia = new EjercicioEnEntrenamientoDAL();
            }

            return Instancia;
        }

        /// <summary>
        /// Se inserta un Ejercicio en Entrenamiento en la base de datos
        /// </summary>
        /// <param name="pIdEntrenamiento"></param>
        /// <param name="pEjercicio"></param>
        public void InsertarEjercicioEnEntrenamiento(int pIdEntrenamiento, EjercicioEnEntrenamiento pEjercicio)
        {
            // Se inserta el registroen la tabla intermida
        }

        /// <summary>
        /// Retorna todos los Ejercicios por Entrenamiento de la base de datos
        /// </summary>
        /// <param name="pIdEntrenamiento"></param>
        /// <returns></returns>
        public List<EjercicioEnEntrenamiento> ObtenerTodosEjerciciosPorEntrenamiento(int pIdEntrenamiento)
        {
            return default;
        }

        /// <summary>
        /// Actualizar un Ejercicio de un Entrenamiento en la base de datos
        /// </summary>
        /// <param name="pIdEntrenamiento"></param>
        /// <param name="pEjercicio"></param>
        public void ActualizarEjercicioEnEntrenamiento(int pIdEntrenamiento, EjercicioEnEntrenamiento pEjercicio)
        {

        }

        /// <summary>
        /// Elimina un Ejercicio de un Entrenamiento en la base de datos
        /// </summary>
        /// <param name="pIdEntrenamiento"></param>
        /// <param name="idEjercicio"></param>
        public void EliminarEjercicioEnEntrenamiento(int pIdEntrenamiento, int idEjercicio)
        {

        }
    }
}
