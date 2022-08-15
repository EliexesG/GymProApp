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
    /// Clase de logica y acceso a datos para los Tipos de Usuarios de la base de datos
    /// </summary>
    public class TipoUsuarioBLL : ITipoUsuarioBLL
    {
        private ITipoUsuarioDAL oTipoUsuarioDAL;

        public TipoUsuarioBLL()
        {
            oTipoUsuarioDAL = TipoUsuarioDAL.GetInstance();
        }

        #region Acceso a datos
        /// <inheritdoc />
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

        /// <inheritdoc />
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
