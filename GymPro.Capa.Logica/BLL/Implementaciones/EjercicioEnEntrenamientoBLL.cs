using GymPro.Capa.Datos.Implementaciones;
using GymPro.Capa.Datos.Interfaces;
using GymPro.Capa.Entidades.Implementaciones;
using GymPro.Capa.Logica.BLL.Interfaces;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GymPro.Capa.Logica.BLL.Implementaciones
{
    public class EjercicioEnEntrenamientoBLL : IEjercicioEnEntrenamientoBLL
    {
        private IEjercicioEnEntrenamientoDAL oEjercicioEnEntrenamientoDAL;

        public EjercicioEnEntrenamientoBLL()
        {
            oEjercicioEnEntrenamientoDAL = EjercicioEnEntrenamientoDAL.GetInstance();
        }

        #region Acceso a datos
        /// <summary>
        /// Elimina un Ejercicio de Entrenamiento de la base de datos
        /// </summary>
        /// <param name="pCodigoEntrenamiento">Codigo del entrenamiento relacionado al ejercicio a eliminar</param>
        /// <param name="pCodigoEjercicio">Codigo del ejercicio de Entrenamiento a eliminar</param>
        public void EliminarEjercicioEnEntrenamiento(int pCodigoEntrenamiento, int pCodigoEjercicio)
        {
            try
            {

                oEjercicioEnEntrenamientoDAL.EliminarEjercicioEnEntrenamiento(pCodigoEntrenamiento, pCodigoEjercicio);

            }
            catch (SqlException sqlError)
            {
                throw sqlError;
            }
            catch (Exception er)
            {
                throw er;
            }
        }

        /// <summary>
        /// Insertar un Ejercicio en Entrenamiento en la base de datos
        /// </summary>
        /// <param name="pEjercicioEnEntrenamiento">Ejercicio en Entrenamiento a eliminar</param>
        public void InsertarEjercicioEnEntrenamiento(EjercicioEnEntrenamiento pEjercicioEnEntrenamiento)
        {

            try
            {

                oEjercicioEnEntrenamientoDAL.InsertarEjercicioEnEntrenamiento(pEjercicioEnEntrenamiento);

            }
            catch (SqlException sqlError)
            {
                throw sqlError;
            }
            catch (Exception er)
            {
                throw er;
            }
        }

        /// <summary>
        /// Modificar un Ejercicio en Entrenamiento en la base de datos
        /// </summary>
        /// <param name="pEjercicioEnEntrenamiento">Ejercicio en Entrenamiento a modificar</param>
        public void ModificarEjercicioEnEntrenamiento(EjercicioEnEntrenamiento pEjercicioEnEntrenamiento)
        {

            try
            {

                oEjercicioEnEntrenamientoDAL.ModificarEjercicioEnEntrenamiento(pEjercicioEnEntrenamiento);

            }
            catch (SqlException sqlError)
            {
                throw sqlError;
            }
            catch (Exception er)
            {
                throw er;
            }
        }

        /// <summary>
        /// Obtiene una lista de Ejercicios en Entrenamiento relacionados al Codigo de Entrenamiento de la base de datos
        /// </summary>
        /// <param name="pCodigoEntrenamiento">Codigo de Entrenamiento relacionado a los Ejercicios en Entrenamiento a buscar</param>
        /// <returns>Lista de entidades de tipo EjericicioEnEntrenamiento</returns>
        public List<EjercicioEnEntrenamiento> ObtenerEjercicioEnEntrenamientoCodigoEntrenamiento(int pCodigoEntrenamiento)
        {

            try
            {

                return oEjercicioEnEntrenamientoDAL.ObtenerEjercicioEnEntrenamientoCodigoEntrenamiento(pCodigoEntrenamiento);

            }
            catch (SqlException sqlError)
            {
                throw sqlError;
            }
            catch (Exception er)
            {
                throw er;
            }
        }

        /// <summary>
        /// Obtiene un Ejercicio en Entrenamiento relacionado a sus Ids de la base de datos
        /// </summary>
        /// <param name="pCodigoEntrenamiento"> Codigo del entrenamiento relacionado al ejercicio a buscar</param>
        /// <param name="pCodigoEjercicio">Codigo del ejercicio de Entrenamiento a buscar</param>
        /// <returns>Entidad de tipo EjercicioEnEntrenamiento</returns>
        public EjercicioEnEntrenamiento ObtenerEjercicioEnEntrenamientoId(int pCodigoEntrenamiento, int pCodigoEjercicio)
        {

            try
            {

                return oEjercicioEnEntrenamientoDAL.ObtenerEjercicioEnEntrenamientoId(pCodigoEntrenamiento, pCodigoEjercicio);

            }
            catch (SqlException sqlError)
            {
                throw sqlError;
            }
            catch (Exception er)
            {
                throw er;
            }
        }

        /// <summary>
        /// Retorna una lista de todos los Ejercicios en Entrenamiento en la base de datos
        /// </summary>
        /// <returns>Lista de entidades de tipo EjercicioEnEntrenamiento</returns>
        public List<EjercicioEnEntrenamiento> ObtenerEjercicioEnEntrenamientoTodos()
        {

            try
            {

                return oEjercicioEnEntrenamientoDAL.ObtenerEjercicioEnEntrenamientoTodos();

            }
            catch (SqlException sqlError)
            {
                throw sqlError;
            }
            catch (Exception er)
            {
                throw er;
            }
        }

        /// <summary>
        /// Retorna una lista de todos los Ejercicios en Entrenamiento de la base de datos pertenecientes a ese codigo de Ejercicio
        /// </summary>
        /// <param name="pCodigoEjercicio">Codigo de Ejercicio de los Ejercicios en Entrenamientos a buscar</param>
        /// <returns>Lista de entidades de tipo EjercicioEnEntrenamiento</returns>
        public List<EjercicioEnEntrenamiento> ObtenerEjercicioEnEntrenamientoCodigoEjercicio(int pCodigoEjercicio)
        {
            try
            {

                return this.ObtenerEjercicioEnEntrenamientoTodos().FindAll(ejercicio => ejercicio.CodigoEjercicio == pCodigoEjercicio).ToList();

            }
            catch (SqlException sqlError)
            {
                throw sqlError;
            }
            catch (Exception er)
            {
                throw er;
            }
        }
        #endregion
    }
}
