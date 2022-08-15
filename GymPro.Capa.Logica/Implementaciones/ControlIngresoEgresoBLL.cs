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
    /// <summary>
    /// Clase de logica y acceso a datos para el Control de Ingreso y Egresos de la base de datos
    /// </summary>
    public class ControlIngresoEgresoBLL : IControlIngresoEgresoBLL
    {
        private IControlIngresoEgresoDAL oControlIngresoEgresoDAL;

        public ControlIngresoEgresoBLL()
        {
            oControlIngresoEgresoDAL = ControlIngresoEgresoDAL.GetInstance();
        }

        #region Acceso a datos
        /// <inheritdoc />
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

        /// <inheritdoc />
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

        /// <inheritdoc />
        public List<ControlIngresoEgreso> ObtenerControlIngresoEgresoIdentificacionUsuario(string pIdentificacionUsuario)
        {
            try
            {
                return oControlIngresoEgresoDAL.ObtenerControlIngresoEgresoIdentificacionUsuario(pIdentificacionUsuario).OrderBy(control => control.Fecha).ToList().
                    FindAll(control => control.HoraSalida != null);

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
        public List<ControlIngresoEgreso> ObtenerControlIngresoEgresoTodos()
        {

            try
            {
                return oControlIngresoEgresoDAL.ObtenerControlIngresoEgresoTodos().OrderBy(control => control.Fecha).ToList().
                    FindAll(control => control.HoraSalida != null); ;

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
