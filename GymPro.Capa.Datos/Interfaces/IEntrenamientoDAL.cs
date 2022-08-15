using GymPro.Capa.Entidades.Implementaciones;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GymPro.Capa.Datos.Interfaces
{
    /// <summary>
    /// Clase de acceso a datos para los Entrenamientos de la base de datos
    /// </summary>
    public interface IEntrenamientoDAL
    {
        /// <summary>
        /// Inserta un Entrenamiento en la base de datos
        /// </summary>
        /// <param name="pEntrenamiento">Entrenamiento a insertar</param>
        void InsertarEntrenamiento(Entrenamiento pEntrenamiento);

        /// <summary>
        /// Modifica un entrenamiento en la base de datos
        /// </summary>
        /// <param name="pEntrenamiento">Entrenamiento a modificar</param>
        void ModificarEntrenamiento(Entrenamiento pEntrenamiento);

        /// <summary>
        /// Elimina un Entrenamiento de la base de datos
        /// </summary>
        /// <param name="pCodigo"> Codigo del entrenamiento a eliminar </param>
        void EliminarEntrenamiento(int pCodigo);

        /// <summary>
        /// Obtiene una lista de todos los Entrenamientos de la base de datos
        /// </summary>
        /// <returns>Lista de entidades de tipo Entrenamiento</returns>
        List<Entrenamiento> ObtenerEntrenamientoTodos();

        /// <summary>
        /// Obtiene un Entrenamiento por su Id de la base de datos
        /// </summary>
        /// <param name="pCodigo">Codigo del entrenamiento a buscar</param>
        /// <returns>Entidad de tipo Entrenamiento</returns>
        Entrenamiento ObtenerEntrenamientoId(int pCodigo);

        /// <summary>
        /// Obtiene una lista de Entrenamientos basado en la Identificacion del Usuario Cliente de la base de datos
        /// </summary>
        /// <param name="pIdentificacionUsuario"> Identificacion del Usuario Cliente </param>
        /// <returns>Lista de entidades de tipo Entrenamiento</returns>
        List<Entrenamiento> ObtenerEntrenamientoIdentificacionUsuarioCliente(string pIdentificacionUsuario);

        /// <summary>
        /// Obtiene una lista de Entrenamientos basado en la Identificacion del Usuario Entrenador de la base de datos
        /// </summary>
        /// <param name="pIdentificacionUsuario"> Identificacion del Usuario Entrenador </param>
        /// <returns>Lista de entidades de tipo Entrenamiento</returns>
        List<Entrenamiento> ObtenerEntrenamientoIdentificacionUsuarioEntrenador(string pIdentificacionUsuario);
    }
}
