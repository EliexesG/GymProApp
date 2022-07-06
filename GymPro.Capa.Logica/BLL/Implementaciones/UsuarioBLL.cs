using GymPro.Capa.Datos;
using GymPro.Capa.Entidades.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GymPro.Capa.Logica.BLL
{
    public class UsuarioBLL : IUsuarioBLL
    {
        private IUsuarioDAL oUsuarioDAL;

        public UsuarioBLL()
        {
            oUsuarioDAL = UsuarioDAL.GetInstance();
        }

        // Aqui van todos los métodos que se comunican con la base de datos

        /// <summary>
        /// Insertar un usuario a la base de datos
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
        /// Actualiza un usuario de la base de datos
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
        /// Retorna todos los usuarios de la base de datos
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
        /// Retorna un usuario por su identifiacion
        /// </summary>
        /// <returns></returns>
        public IUsuario SeleccionarUsuarioPorId(string pId)
        {
            try
            {
                return oUsuarioDAL.SeleccionarUsuarioPorId(pId);
            }
            catch (Exception er)
            {
                throw er;
            }
        }

        /// <summary>
        /// Se elimina el usuario por su id
        /// </summary>
        /// <param name="pId"></param>
        public void EliminarUsuarioPorId(string pId)
        {
            try
            {
                oUsuarioDAL.EliminarUsuarioPorId(pId);
            }
            catch (Exception er)
            {
                throw er;
            }
        }
    }
}
