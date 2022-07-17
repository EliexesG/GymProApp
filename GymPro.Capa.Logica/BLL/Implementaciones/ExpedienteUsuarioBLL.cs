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
