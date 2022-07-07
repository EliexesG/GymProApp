using GymPro.Capa.Datos.Implementaciones;
using GymPro.Capa.Datos.Interfaces;
using GymPro.Capa.Entidades.Implementaciones;
using GymPro.Capa.Logica.BLL.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GymPro.Capa.Logica.BLL.Implementaciones
{
    class EjercicioEnEntrenamientoBLL : IEjercicioEnEntrenamientoBLL
    {

        private IEjercicioEnEntrenamientoDAL oEjercicioEnEntrenamientoDAL;

        public EjercicioEnEntrenamientoBLL()
        {
            oEjercicioEnEntrenamientoDAL = EjercicioEnEntrenamientoDAL.GetInstance();
        }

        /// <summary>
        /// Se inserta un Ejercicio en Entrenamiento en la base de datos
        /// </summary>
        /// <param name="pIdEntrenamiento"></param>
        /// <param name="pEjercicio"></param>
        public void InsertarEjercicioEnEntrenamiento(EjercicioEnEntrenamiento pEjercicio)
        {
            // Se inserta el registroen la tabla intermida
        }

        /// <summary>
        /// Elimina un Ejercicio de un Entrenamiento en la base de datos
        /// </summary>
        /// <param name="pIdEntrenamiento"></param>
        /// <param name="idEjercicio"></param>
        public void EliminarEjercicioEnEntrenamientoID(int pIdEntrenamiento, int idEjercicio)
        {

        }

        /// <summary>
        /// Actualizar un Ejercicio de un Entrenamiento en la base de datos
        /// </summary>
        /// <param name="pIdEntrenamiento"></param>
        /// <param name="pEjercicio"></param>
        public void ActualizarEjercicioEnEntrenamiento(EjercicioEnEntrenamiento pEjercicio)
        {

        }

        /// <summary>
        /// Retorna todos los Ejercicios en entrenamientos de la base de datos
        /// </summary>
        /// <param name="pIdEntrenamiento"></param>
        /// <returns></returns>
        public List<EjercicioEnEntrenamiento> ObtenerTodosEjerciciosDeEntrenamientos()
        {
            return default;
        }

        /// <summary>
        /// Retorna todos los ejercicios de un entrenamiento en especifico por su Id de la base de datos
        /// </summary>
        /// <param name="pId"></param>
        /// <returns></returns>
        public List<EjercicioEnEntrenamiento> ObtenerEjerciciosEnEntrenamientosPorIDEntrenamiento(int pId)
        {
            return default;
        }

    }
}
