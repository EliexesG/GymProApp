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
    public class TipoUsuarioBLL : ITipoUsuarioBLL
    {
        private ITipoUsuarioDAL oTipoUsuarioDAL;

        public TipoUsuarioBLL()
        {
            oTipoUsuarioDAL = TipoUsuarioDAL.GetInstance();
        }

        #region Acceso a datos
        /// <summary>
        /// Obtiene un Tipo de Usuario por su Id de la base de datos
        /// </summary>
        /// <param name="pCodigo">Codigo del Tipo de Usuario a buscar</param>
        /// <returns>Entidad de tipo TipoUsuario</returns>
        public TipoUsuario ObtenerTipoUsuarioId(int pCodigo)
        {
            try
            {
                return oTipoUsuarioDAL.ObtenerTipoUsuarioId(pCodigo);

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
        /// Obtiene una lista de todos Tipos de Usuario de la base de datos
        /// </summary>
        /// <returns>Lista de entidades de tipo TipoUsuario</returns>
        public List<TipoUsuario> ObtenerTipoUsuarioTodos()
        {
            try
            {
                return oTipoUsuarioDAL.ObtenerTipoUsuarioTodos();

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
