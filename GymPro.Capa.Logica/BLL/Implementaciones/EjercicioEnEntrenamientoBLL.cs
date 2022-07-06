using GymPro.Capa.Datos;
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
        public void InsertarEjercicioEnEntrenamiento(int pIdEntrenamiento, EjercicioEnEntrenamiento pEjercicio)
        {
            try
            {
                oEjercicioEnEntrenamientoDAL.InsertarEjercicioEnEntrenamiento(pIdEntrenamiento, pEjercicio);
            }
            catch (Exception er)
            {
                throw er;
            }
        }

        /// <summary>
        /// Retorna todos los Ejercicios por Entrenamiento de la base de datos
        /// </summary>
        /// <param name="pIdEntrenamiento"></param>
        /// <returns></returns>
        public List<EjercicioEnEntrenamiento> ObtenerTodosEjerciciosPorEntrenamiento(int pIdEntrenamiento)
        {
            try
            {
                return oEjercicioEnEntrenamientoDAL.ObtenerTodosEjerciciosPorEntrenamiento(pIdEntrenamiento);
            }
            catch(Exception er)
            {
                throw er;
            }
        }

        /// <summary>
        /// Actualizar un Ejercicio de un Entrenamiento en la base de datos
        /// </summary>
        /// <param name="pIdEntrenamiento"></param>
        /// <param name="pEjercicio"></param>
        public void ActualizarEjercicioEnEntrenamiento(int pIdEntrenamiento, EjercicioEnEntrenamiento pEjercicio)
        {
            try
            {
                oEjercicioEnEntrenamientoDAL.ActualizarEjercicioEnEntrenamiento(pIdEntrenamiento, pEjercicio);
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
        public void EliminarEjercicioEnEntrenamiento(int pIdEntrenamiento, int idEjercicio)
        {
            try
            {
                oEjercicioEnEntrenamientoDAL.EliminarEjercicioEnEntrenamiento(pIdEntrenamiento, idEjercicio);
            }
            catch (Exception er)
            {
                throw er;
            }
        }
    }
}
