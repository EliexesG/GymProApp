using GymPro.Capa.Entidades.Implementaciones;
using System.Collections.Generic;

namespace GymPro.Capa.Logica.Interfaces
{
    /// <summary>
    /// Clase de logica y acceso a datos para los Entrenamientos de la base de datos
    /// </summary>
    public interface IEntrenamientoBLL
    {
        /// <summary>
        /// Elimina un Entrenamiento de la base de datos
        /// </summary>
        /// <param name="pCodigo"> Codigo del entrenamiento a eliminar </param>
        void EliminarEntrenamiento(int pCodigo);

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

        /// <summary>
        /// Obtiene una lista de todos los Entrenamientos de la base de datos
        /// </summary>
        /// <returns>Lista de entidades de tipo Entrenamiento</returns>
        List<Entrenamiento> ObtenerEntrenamientoTodos();


        /// <summary>
        /// Obtiene el ultimo codigo de entrenamiento agregado a la base de datos según el cliente
        /// </summary>
        /// <param name="pIdentificacion"></param>
        /// <returns>Integer con el codigo de entrenamiento</returns>
        int UltimoCodigoEntrenamientoAgregadoCliente(string pIdentificacion);
    }
}