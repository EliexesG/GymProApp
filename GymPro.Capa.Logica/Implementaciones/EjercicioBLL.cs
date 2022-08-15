using GymPro.Capa.Datos.Implementaciones;
using GymPro.Capa.Datos.Interfaces;
using GymPro.Capa.Entidades.Implementaciones;
using GymPro.Capa.Logica.Interfaces;
using GymPro.Capa.Util;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace GymPro.Capa.Logica.Implementaciones
{
    /// <summary>
    /// Clase de logica y acceso a datos para los Ejercicios de la base de datos
    /// </summary>
    public class EjercicioBLL : IEjercicioBLL
    {

        //Log4net
        private static readonly log4net.ILog _MyLogControlEventos = log4net.LogManager.GetLogger("MyControlEventos");

        private IEjercicioDAL oEjercicioDAL;

        public EjercicioBLL()
        {
            oEjercicioDAL = EjercicioDAL.GetInstance();
        }

        #region Acceso a datos
        /// <inheritdoc />
        public void EliminarEjercicio(int pCodigo)
        {
            try
            {

                oEjercicioDAL.EliminarEjercicio(pCodigo);

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
        public void InsertarEjercicio(Ejercicio pEjercicio)
        {
            try
            {

                oEjercicioDAL.InsertarEjercicio(pEjercicio);

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
        public void ModificarEjercicio(Ejercicio pEjercicio)
        {
            try
            {

                oEjercicioDAL.ModificarEjercicio(pEjercicio);

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
        public List<Ejercicio> ObtenerEjercicioCodigoTipo(int pCodigoTipo)
        {
            try
            {

                return oEjercicioDAL.ObtenerEjercicioCodigoTipo(pCodigoTipo).OrderBy(ejercicio => ejercicio.CodigoTipo).ThenBy(ejercicio => ejercicio.Nombre).ToList(); ;

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
        public Ejercicio ObtenerEjercicioId(int pCodigo)
        {
            try
            {

                return oEjercicioDAL.ObtenerEjercicioId(pCodigo);

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
        public List<Ejercicio> ObtenerEjercicioTodos()
        {
            try
            {

                return oEjercicioDAL.ObtenerEjercicioTodos().OrderBy(ejercicio => ejercicio.CodigoTipo).ThenBy(ejercicio => ejercicio.Nombre).ToList();

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
        public List<Ejercicio> ObtenerEjercicioDisponibleCodigoEntrenamiento(int pCodigo)
        {

            List<Ejercicio> ejercicios = new List<Ejercicio>();

            try
            {
                EjercicioEnEntrenamientoBLL logica = new EjercicioEnEntrenamientoBLL();
                List<EjercicioEnEntrenamiento> ejerciciosDeLEntrenamiento = logica.ObtenerEjercicioEnEntrenamientoCodigoEntrenamiento(pCodigo);

                ObtenerEjercicioTodos().ForEach(ejercicio =>
                {
                    if(ejerciciosDeLEntrenamiento.LastOrDefault(buscado => buscado.CodigoEjercicio.Equals(ejercicio.Codigo)) == null)
                    {
                        ejercicios.Add(ejercicio);
                    }
                });


                return ejercicios;
            }
            catch (SqlException sqlError)
            {
                throw sqlError;
            }
            catch (Exception er)
            {
                StringBuilder msg = new StringBuilder();
                msg.AppendFormat(Utilitarios.CreateGenericErrorExceptionDetail(MethodBase.GetCurrentMethod(), er));
                _MyLogControlEventos.ErrorFormat("Error {0}", msg.ToString());


                throw er;
            }
        }

        /// <inheritdoc />
        public List<Ejercicio> ObtenerEjercicioDisponibleCodigoEntrenamientoYTipoEjercicio(int pCodigoEntrenamiento, int pTipoEjercicio)
        {
            try
            {
                return this.ObtenerEjercicioDisponibleCodigoEntrenamiento(pCodigoEntrenamiento).FindAll(ejercicio => ejercicio.CodigoTipo == pTipoEjercicio).ToList();
            }
            catch (SqlException sqlError)
            {
                throw sqlError;
            }
            catch (Exception er)
            {
                StringBuilder msg = new StringBuilder();
                msg.AppendFormat(Utilitarios.CreateGenericErrorExceptionDetail(MethodBase.GetCurrentMethod(), er));
                _MyLogControlEventos.ErrorFormat("Error {0}", msg.ToString());


                throw er;
            }
        }
        #endregion
    }
}
