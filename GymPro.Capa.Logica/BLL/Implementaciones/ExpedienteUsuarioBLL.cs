using GymPro.Capa.Datos.Implementaciones;
using GymPro.Capa.Datos.Interfaces;
using GymPro.Capa.Entidades.Implementaciones;
using GymPro.Capa.Logica.BLL.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GymPro.Capa.Logica.BLL.Implementaciones
{
    class ExpedienteUsuarioBLL : IExpedienteUsuarioBLL
    {

        private IExpedienteUsuarioDAL oExpedienteUsuarioDAL;

        public ExpedienteUsuarioBLL()
        {
            oExpedienteUsuarioDAL = ExpedienteUsuarioDAL.GetInstance();
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
