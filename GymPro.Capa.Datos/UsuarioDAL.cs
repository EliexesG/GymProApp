using GymPro.Capa.Entidades.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GymPro.Capa.Datos
{
    public class UsuarioDAL
    {

        private static UsuarioDAL Instancia;

        /// <summary>
        /// Retorna instancia de tipo UsuarioDAL
        /// </summary>
        /// <returns></returns>
        public static UsuarioDAL GetInstance()
        {
            if (Instancia == null)
            {
                Instancia = new UsuarioDAL();
            }

            return Instancia;
        }

        // Aqui van todos los métodos que se comunican con la base de datos
        /// <summary>
        /// Insertar un usuario a la base de datos
        /// </summary>
        /// <param name="usuario"></param>
        public void InsertarUsuario(IUsuario usuario)
        {
            // Aqui va toda la logica para insertar el usuario a la base de datos
            // Donde se llaman los Stored Procedures que hacen las operaciones de la base de datos
        }

        /// <summary>
        /// Actualiza un usuario de la base de datos
        /// </summary>
        /// <param name="usuario"></param>
        public void ActualizarUsuario(IUsuario usuario)
        {
            // Aqui va toda la logica para insertar el usuario a la base de datos
            // Donde se llaman los Stored Procedures que hacen las operaciones de la base de datos
        }

        /// <summary>
        /// Retorna todos los usuarios de la base de datos
        /// </summary>
        /// <returns></returns>
        public List<IUsuario> SeleccionarTodosUsuarios()
        {
            return null;
        }

        /// <summary>
        /// Retorna un usuario por su identifiacion
        /// </summary>
        /// <returns></returns>
        public IUsuario SeleccionarUsuarioPorId(string id)
        {
            return null;
        }

        /// <summary>
        /// Se elimina el usuario por su id
        /// </summary>
        /// <param name="id"></param>
        public void EliminarUsuarioPorId(string id)
        {

        }
    }
}
