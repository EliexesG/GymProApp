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
    /// Clase de logica y acceso a datos para los Entrenamientos de la base de datos
    /// </summary>
    public class EntrenamientoBLL : IEntrenamientoBLL
    {
        private IEntrenamientoDAL oEntrenamientoDAL;

        public EntrenamientoBLL()
        {
            oEntrenamientoDAL = EntrenamientoDAL.GetInstance();
        }

        #region Acceso a datos
        /// <inheritdoc />
        public void EliminarEntrenamiento(int pCodigo)
        {

            try
            {

                oEntrenamientoDAL.EliminarEntrenamiento(pCodigo);

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
        public void InsertarEntrenamiento(Entrenamiento pEntrenamiento)
        {
            try
            {

                oEntrenamientoDAL.InsertarEntrenamiento(pEntrenamiento);

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
        public void ModificarEntrenamiento(Entrenamiento pEntrenamiento)
        {
            try
            {

                oEntrenamientoDAL.ModificarEntrenamiento(pEntrenamiento);

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
        public Entrenamiento ObtenerEntrenamientoId(int pCodigo)
        {
            try
            {

                return oEntrenamientoDAL.ObtenerEntrenamientoId(pCodigo);

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
        public List<Entrenamiento> ObtenerEntrenamientoIdentificacionUsuarioCliente(string pIdentificacionUsuario)
        {

            try
            {

                return oEntrenamientoDAL.ObtenerEntrenamientoIdentificacionUsuarioCliente(pIdentificacionUsuario);

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
        public List<Entrenamiento> ObtenerEntrenamientoIdentificacionUsuarioEntrenador(string pIdentificacionUsuario)
        {
            try
            {

                return oEntrenamientoDAL.ObtenerEntrenamientoIdentificacionUsuarioEntrenador(pIdentificacionUsuario);

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
        public List<Entrenamiento> ObtenerEntrenamientoTodos()
        {
            try
            {

                return oEntrenamientoDAL.ObtenerEntrenamientoTodos();

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
        public int UltimoCodigoEntrenamientoAgregadoCliente(string pIdentificacion)
        {
            try
            {

                return ObtenerEntrenamientoIdentificacionUsuarioCliente(pIdentificacion).Max(entrenamiento => entrenamiento.Codigo);

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
