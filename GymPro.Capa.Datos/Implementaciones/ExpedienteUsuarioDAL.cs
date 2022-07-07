using GymPro.Capa.Datos.Interfaces;
using GymPro.Capa.Entidades.Implementaciones;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GymPro.Capa.Datos.Implementaciones
{
    public class ExpedienteUsuarioDAL : IExpedienteUsuarioDAL
    {

        private static ExpedienteUsuarioDAL Instancia;

        /// <summary>
        /// Retorna instancia de tipo ExpedienteUsuarioDAL
        /// </summary>
        /// <returns></returns>
        public static ExpedienteUsuarioDAL GetInstance()
        {
            if (Instancia == null)
            {
                Instancia = new ExpedienteUsuarioDAL();
            }

            return Instancia;
        }

        /// <summary>
        /// Inserta un expediente de usuario en la base de datos
        /// </summary>
        /// <param name="pExpediente"></param>
        public void InsertarExpedienteUsuario(ExpedienteUsuario pExpediente)
        {

        }

        /// <summary>
        /// Elimina un expediente de usuario por Id de la base de datos
        /// </summary>
        /// <param name="pIdUsuario"></param>
        public void EliminarExpedienteUsuarioPorID(string pIdUsuario)
        {

        }

        /// <summary>
        /// Actualiza un expediente de usuario de la base de datos
        /// </summary>
        /// <param name="pExpediente"></param>
        public void ActualizarExpedienteUsuario(ExpedienteUsuario pExpediente)
        {

        }

        /// <summary>
        /// Retorna una lista con todos los expedientes de usuario de la base de datos
        /// </summary>
        /// <returns></returns>
        public List<ExpedienteUsuario> SeleccionarTodosExpedientesUsuarios()
        {
            return default;
        }

        /// <summary>
        /// Retorna un expediente de usuario por su Id de la base de datos
        /// </summary>
        /// <param name="pIdUsuario"></param>
        /// <returns></returns>
        public ExpedienteUsuario SeleccionarExpedienteUsuarioPorID(string pIdUsuario)
        {
            return default;
        }

    }
}
