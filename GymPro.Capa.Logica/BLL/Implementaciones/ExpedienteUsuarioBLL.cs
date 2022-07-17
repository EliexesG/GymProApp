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
    public class ExpedienteUsuarioBLL : IExpedienteUsuarioBLL
    {

        private IExpedienteUsuarioDAL oExpedienteUsuarioDAL;

        public ExpedienteUsuarioBLL()
        {
            oExpedienteUsuarioDAL = ExpedienteUsuarioDAL.GetInstance();
        }



        #region Acceso a datos
        /// <summary>
        /// Elimina un Expediente de Usuario de la base de datos por sus Ids
        /// </summary>
        /// <param name="pFecha"> Fecha del Expediente Usuario a eliminar </param>
        /// <param name="pIdentificacionUsuario"> Identificacion del Usuario relacionado al Expediente Usuario a Eliminar</param>
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

        /// <summary>
        /// Inserta un Expediente de Usuario en la base de datos
        /// </summary>
        /// <param name="pExpediente"> Expediente de Usuario a insertar </param>
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

        /// <summary>
        /// Modifica un Expediente de Usuario en la base de datos
        /// </summary>
        /// <param name="pExpediente"> El Expediente de Usuario a Modificar </param>
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

        /// <summary>
        /// Obtiene un Expediente de Usuario especifico de la base de datos por medio de sus Ids
        /// </summary>
        /// <param name="pFecha"> Fecha del Expediente Usuario a buscar </param>
        /// <param name="pIdentificacionUsuario"> Identificacion del Usuario relacionado al Expediente Usuario a buscar </param>
        /// <returns>Entidad de tipo ExpedienteUsuario</returns>
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

        /// <summary>
        /// Obtiene una lista historial con todos los Expedientes de Usuario relacionados a la Identificacion de Usuario de la base de datos
        /// </summary>
        /// <param name="pIdentificacionUsuario"> Identificacion  del Usuario relacionado a los Expedientes de Usuario a buscar </param>
        /// <returns>Lista de Entidades de tipo ExpedienteUsuario</returns>
        public List<ExpedienteUsuario> ObtenerExpedienteUsuarioIdentificacionUsuario(string pIdentificacionUsuario)
        {
            try
            {

                return oExpedienteUsuarioDAL.ObtenerExpedienteUsuarioIdentificacionUsuario(pIdentificacionUsuario);

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
        /// Obtiene una lista de todos los Expedientes de Usuario almacenados en la base de datos
        /// </summary>
        /// <returns>Lista de Entidades de tipo ExpedienteUsuario</returns>
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
