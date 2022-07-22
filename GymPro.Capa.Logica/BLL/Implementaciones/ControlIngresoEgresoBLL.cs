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
    public class ControlIngresoEgresoBLL : IControlIngresoEgresoBLL
    {
        private IControlIngresoEgresoDAL oControlIngresoEgresoDAL;

        public ControlIngresoEgresoBLL()
        {
            oControlIngresoEgresoDAL = ControlIngresoEgresoDAL.GetInstance();
        }

        #region Acceso a datos
        /// <summary>
        /// Inserta la Hora de Inicio de un Control de Ingreso y Egreso en la base de datos
        /// </summary>
        /// <param name="pControlIngresoEgreso">Control de Ingreso y Egreso a insertar</param>
        public void InsertarIngreso(ControlIngresoEgreso pControlIngresoEgreso)
        {

            try
            {
                oControlIngresoEgresoDAL.InsertarIngreso(pControlIngresoEgreso);

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
        /// Modifica un Control de Ingreso y Egreso con la Hora de Salida en la base de datos
        /// </summary>
        /// <param name="pControlIngresoEgreso">Control de Ingreso y Egreso a insertar</param>
        public void ModificarEgreso(ControlIngresoEgreso pControlIngresoEgreso)
        {

            try
            {
                oControlIngresoEgresoDAL.ModificarEgreso(pControlIngresoEgreso);

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
        /// Obtiene una lista de los Controles de Ingreso y Egreso de un Usuario de la base de datos
        /// </summary>
        /// <param name="pIdentificacionUsuario">Identificacion del Usuario relacionado a los Controles de Ingreso y Egreso a buscar</param>
        /// <returns>Lista de entidades de tipo ControlIngresoEgreso</returns>
        public List<ControlIngresoEgreso> ObtenerControlIngresoEgresoIdentificacionUsuario(string pIdentificacionUsuario)
        {
            try
            {
                return oControlIngresoEgresoDAL.ObtenerControlIngresoEgresoIdentificacionUsuario(pIdentificacionUsuario);

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
        /// Obtiene una lista de todos los Controles de Ingreso y Egreso de la base de datos
        /// </summary>
        /// <returns>Lista de entidades de tipo ControlIngresoEgreso</returns>
        public List<ControlIngresoEgreso> ObtenerControlIngresoEgresoTodos()
        {

            try
            {
                return oControlIngresoEgresoDAL.ObtenerControlIngresoEgresoTodos();

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
        /// Obtiene el ultimo Control de Ingreso y Egreso de un Usuario de la base de daots
        /// </summary>
        /// <param name="pIdentificacionUsuario">Identificacion del Usuario relacionado al Control de Ingreso y Egreso a buscar</param>
        /// <returns>Entidad de tipo ControlIngresoEgreso</returns>
        public ControlIngresoEgreso ObtenerControlIngresoEgresoUltimoIdentificacionUsuario(string pIdentificacionUsuario)
        {

            try
            {
                return oControlIngresoEgresoDAL.ObtenerControlIngresoEgresoUltimoIdentificacionUsuario(pIdentificacionUsuario);

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
