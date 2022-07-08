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

        #region Acceso a datos
        /// <summary>
        /// Se inserta un Ejercicio en Entrenamiento en la base de datos
        /// </summary>
        /// <param name="pIdEntrenamiento"></param>
        /// <param name="pEjercicio"></param>
        public void InsertarEjercicioEnEntrenamiento(EjercicioEnEntrenamiento pEjercicio)
        {
            try
            {
                oEjercicioEnEntrenamientoDAL.InsertarEjercicioEnEntrenamiento(pEjercicio);
            }
            catch (Exception er)
            {
                throw er;
            }
        }

        /// <summary>
        /// Elimina un Ejercicio de un Entrenamiento en la base de datos
        /// </summary>
        /// <param name="pIdEntrenamiento"></param>
        /// <param name="idEjercicio"></param>
        public void EliminarEjercicioEnEntrenamientoID(int pIdEntrenamiento, int idEjercicio)
        {
            try
            {
                oEjercicioEnEntrenamientoDAL.EliminarEjercicioEnEntrenamientoID(pIdEntrenamiento, idEjercicio);
            }
            catch (Exception er)
            {
                throw er;
            }
        }

        /// <summary>
        /// Actualizar un Ejercicio de un Entrenamiento en la base de datos
        /// </summary>
        /// <param name="pIdEntrenamiento"></param>
        /// <param name="pEjercicio"></param>
        public void ActualizarEjercicioEnEntrenamiento(EjercicioEnEntrenamiento pEjercicio)
        {
            try
            {
                oEjercicioEnEntrenamientoDAL.ActualizarEjercicioEnEntrenamiento(pEjercicio);
            }
            catch (Exception er)
            {
                throw er;
            }
        }

        /// <summary>
        /// Retorna todos los Ejercicios en entrenamientos de la base de datos
        /// </summary>
        /// <param name="pIdEntrenamiento"></param>
        /// <returns></returns>
        public List<EjercicioEnEntrenamiento> ObtenerTodosEjerciciosDeEntrenamientos()
        {
            try
            {
                return oEjercicioEnEntrenamientoDAL.ObtenerTodosEjerciciosDeEntrenamientos();
            }
            catch (Exception er)
            {
                throw er;
            }
        }

        /// <summary>
        /// Retorna todos los ejercicios de un entrenamiento en especifico por su Id de la base de datos
        /// </summary>
        /// <param name="pId"></param>
        /// <returns></returns>
        public List<EjercicioEnEntrenamiento> ObtenerEjerciciosEnEntrenamientosPorIDEntrenamiento(int pId)
        {
            try
            {
                return oEjercicioEnEntrenamientoDAL.ObtenerEjerciciosEnEntrenamientosPorIDEntrenamiento(pId);
            }
            catch (Exception er)
            {
                throw er;
            }
        }
        #endregion
    }
}
