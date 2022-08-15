using GymPro.Capa.Entidades.Implementaciones;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GymPro.Capa.Datos.Interfaces
{
    /// <summary>
    /// Clase de acceso a datos para los Tipos de Usuarios de la base de datos
    /// </summary>
    public interface ITipoUsuarioDAL
    {
        /// <summary>
        /// Obtiene una lista de todos Tipos de Usuario de la base de datos
        /// </summary>
        /// <returns>Lista de entidades de tipo TipoUsuario</returns>
        List<TipoUsuario> ObtenerTipoUsuarioTodos();

        /// <summary>
        /// Obtiene un Tipo de Usuario por su Id de la base de datos
        /// </summary>
        /// <param name="pCodigo">Codigo del Tipo de Usuario a buscar</param>
        /// <returns>Entidad de tipo TipoUsuario</returns>
        TipoUsuario ObtenerTipoUsuarioId(int pCodigo);
    }
}
