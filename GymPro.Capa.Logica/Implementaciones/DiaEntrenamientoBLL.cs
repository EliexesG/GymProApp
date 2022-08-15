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
    /// Clase de logica y acceso a datos para los Dias de Entrenamiento de la base de datos
    /// </summary>
    public class DiaEntrenamientoBLL : IDiaEntrenamientoBLL
    {

        //Log4net
        private static readonly log4net.ILog _MyLogControlEventos = log4net.LogManager.GetLogger("MyControlEventos");

        private IDiaEntrenamientoDAL oDiaEntrenamientoDAL;

        public DiaEntrenamientoBLL()
        {
            oDiaEntrenamientoDAL = DiaEntrenamientoDAL.GetInstance();
        }

        #region Acceso a datos
        /// <inheritdoc />
        public void EliminarDiaEntrenamiento(DiaEntrenamiento pDiaEntrenamiento)
        {
            try
            {

                oDiaEntrenamientoDAL.EliminarDiaEntrenamiento(pDiaEntrenamiento);

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
        public void InsertarDiaEntrenamiento(DiaEntrenamiento pDiaEntrenamiento)
        {
            try
            {

                oDiaEntrenamientoDAL.InsertarDiaEntrenamiento(pDiaEntrenamiento);

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
        public List<DiaEntrenamiento> ObtenerDiaEntrenamientoCodigoEntrenamiento(int pCodigoEntrenamiento)
        {
            try
            {

                return oDiaEntrenamientoDAL.ObtenerDiaEntrenamientoCodigoEntrenamiento(pCodigoEntrenamiento).OrderBy(dia => dia.Dia).ToList();

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
        public List<DiaEntrenamiento> ObtenerDiaEntrenamientoTodos()
        {

            try
            {

                return oDiaEntrenamientoDAL.ObtenerDiaEntrenamientoTodos().OrderBy(dia => dia.Dia).ToList();

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
        public List<Dia> ObtenerDiaDisponibleSobreCodigoEntrenamiento(int pCodigoEntrenamiento)
        {
            try
            {
                List<DiaEntrenamiento> diasEntrenamiento = this.ObtenerDiaEntrenamientoCodigoEntrenamiento(pCodigoEntrenamiento);
                List<Dia> dias = new List<Dia>();

                foreach (Dia dia in Enum.GetValues(typeof(Dia)))
                {
                    if(diasEntrenamiento.FirstOrDefault(diaEntrenamiento => diaEntrenamiento.Dia == (int)dia) == null)
                    {
                        dias.Add(dia);
                    }
                }

                return dias;

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
