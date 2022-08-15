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
    /// Clase de logica y acceso a datos para los Expedientes de Usuarios de la base de datos
    /// </summary>
    public class ExpedienteUsuarioBLL : IExpedienteUsuarioBLL
    {

        //Log4net
        private static readonly log4net.ILog _MyLogControlEventos = log4net.LogManager.GetLogger("MyControlEventos");

        private IExpedienteUsuarioDAL oExpedienteUsuarioDAL;

        public ExpedienteUsuarioBLL()
        {
            oExpedienteUsuarioDAL = ExpedienteUsuarioDAL.GetInstance();
        }

        #region Logica
        /// <inheritdoc />
        public double CalcularIMC(ExpedienteUsuario pExpedienteUsuario)
        {
            try
            {

                return Math.Round(pExpedienteUsuario.Peso / (Math.Pow(pExpedienteUsuario.Altura / 100f, 2)));

            }
            catch(DivideByZeroException er)
            {
                StringBuilder msg = new StringBuilder();
                msg.AppendFormat(Utilitarios.CreateGenericErrorExceptionDetail(MethodBase.GetCurrentMethod(), er));
                _MyLogControlEventos.ErrorFormat("Error {0}", msg.ToString());

                throw new DivideByZeroException("No se puede sacar el IMC, división entre 0");
            }
            
        }

        /// <inheritdoc />
        public double CalcularMetabolismoBasal(ExpedienteUsuario pExpedienteUsuario, int pEdad, Genero pGenero)
        {
            return (10 * pExpedienteUsuario.Peso) + (6.25 * pExpedienteUsuario.Altura) 
                - (5 * pEdad) + (pGenero == Genero.Masculino ? 5 : -161);
        }
        #endregion

        #region Acceso a datos
        /// <inheritdoc />
        public void EliminarExpedienteUsuario(DateTime pFecha, string pIdentificacionUsuario)
        {
            try
            {

                oExpedienteUsuarioDAL.EliminarExpedienteUsuario(pFecha, pIdentificacionUsuario);

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
        public void InsertarExpedienteUsuario(ExpedienteUsuario pExpediente)
        {
            try
            {

                oExpedienteUsuarioDAL.InsertarExpedienteUsuario(pExpediente);

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
        public void ModificarExpedienteUsuario(ExpedienteUsuario pExpediente)
        {
            try
            {

                oExpedienteUsuarioDAL.ModificarExpedienteUsuario(pExpediente);

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
        public ExpedienteUsuario ObtenerExpedienteUsuarioId(DateTime pFecha, string pIdentificacionUsuario)
        {
            try
            {

                return oExpedienteUsuarioDAL.ObtenerExpedienteUsuarioId(pFecha, pIdentificacionUsuario);

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
        public List<ExpedienteUsuario> ObtenerExpedienteUsuarioIdentificacionUsuario(string pIdentificacionUsuario)
        {
            try
            {

                return oExpedienteUsuarioDAL.ObtenerExpedienteUsuarioIdentificacionUsuario(pIdentificacionUsuario).
                    OrderBy(expediente => expediente.Fecha).ToList();

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
        public List<ExpedienteUsuario> ObtenerExpedienteUsuarioTodos()
        {
            try
            {

                return oExpedienteUsuarioDAL.ObtenerExpedienteUsuarioTodos();

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
