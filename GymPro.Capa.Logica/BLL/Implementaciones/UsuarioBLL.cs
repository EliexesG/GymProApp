using GymPro.Capa.Datos.Implementaciones;
using GymPro.Capa.Datos.Interfaces;
using GymPro.Capa.Entidades.Interfaces;
using GymPro.Capa.Logica.BLL.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GymPro.Capa.Logica.BLL.Implementaciones
{
    class UsuarioBLL : IUsuarioBLL
    {

        private IUsuarioDAL oUsuarioDAL;

        public UsuarioBLL()
        {
            oUsuarioDAL = UsuarioDAL.GetInstance();
        }

        #region Acceso a datos
        /// <summary>
        /// Insertar usuario en la base de datos
        /// </summary>
        /// <param name="pUsuario"></param>
        public void InsertarUsuario(IUsuario pUsuario)
        {
            try
            {
                oUsuarioDAL.InsertarUsuario(pUsuario);
            }
            catch (Exception er)
            {
                throw er;
            }
        }

        /// <summary>
        /// Eliminar usuario segun su Id de la base de datos
        /// </summary>
        /// <param name="pId"></param>
        public void EliminarUsuarioPorID(string pId)
        {
            try
            {
                oUsuarioDAL.EliminarUsuarioPorID(pId);
            }
            catch (Exception er)
            {
                throw er;
            }
        }

        /// <summary>
        /// Actualizar un usuario en la base de datos
        /// </summary>
        /// <param name="pUsuario"></param>
        public void ActualizarUsuario(IUsuario pUsuario)
        {
            try
            {
                oUsuarioDAL.ActualizarUsuario(pUsuario);
            }
            catch (Exception er)
            {
                throw er;
            }
        }

        /// <summary>
        /// Retorna una lista con todos los usuarios de la base de datos
        /// </summary>
        /// <returns></returns>
        public List<IUsuario> SeleccionarTodosUsuarios()
        {
            try
            {
                return oUsuarioDAL.SeleccionarTodosUsuarios();
            }
            catch (Exception er)
            {
                throw er;
            }
        }

        /// <summary>
        /// Retorna un usuario segun su Id de la base de datos
        /// </summary>
        /// <param name="pId"></param>
        /// <returns></returns>
        public IUsuario SeleccionarUsuarioPorID(string pId)
        {
            try
            {
                return oUsuarioDAL.SeleccionarUsuarioPorID(pId);
            }
            catch (Exception er)
            {
                throw er;
            }
        }
        #endregion
    }
}
