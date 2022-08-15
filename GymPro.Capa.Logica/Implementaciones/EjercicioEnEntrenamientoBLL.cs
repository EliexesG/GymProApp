using GymPro.Capa.Datos.Implementaciones;
using GymPro.Capa.Datos.Interfaces;
using GymPro.Capa.Entidades.Implementaciones;
using GymPro.Capa.Logica.Interfaces;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GymPro.Capa.Logica.Implementaciones
{
    /// <summary>
    /// Clase de logica y acceso a datos para los Ejercicios en Entrenamiento de la base de datos
    /// </summary>
    public class EjercicioEnEntrenamientoBLL : IEjercicioEnEntrenamientoBLL
    {
        private IEjercicioEnEntrenamientoDAL oEjercicioEnEntrenamientoDAL;

        public EjercicioEnEntrenamientoBLL()
        {
            oEjercicioEnEntrenamientoDAL = EjercicioEnEntrenamientoDAL.GetInstance();
        }

        #region Acceso a datos
        /// <inheritdoc />
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

        /// <inheritdoc />
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

        /// <inheritdoc />
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

        /// <inheritdoc />
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

        /// <inheritdoc />
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

        /// <inheritdoc />
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

        /// <inheritdoc />
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
