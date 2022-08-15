using GymPro.Capa.Entidades.Implementaciones;
using GymPro.Capa.Entidades.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GymPro.Capa.Factories
{
    /// <summary>
    /// Clase encargada de crear Usuarios
    /// </summary>
    public class FactoryUsuario
    {
        /// <summary>
        /// En base al enum representando el Tipo de Usuario, se crea una instancia de ese Usuario
        /// </summary>
        /// <param name="tipoUsuario">Tipo de Usuario a crear</param>
        /// <returns>Un Usuario de tipo IUsuario (realmente siendo de sus clases inferiores)</returns>
        public static IUsuario CrearUsuario(TipoUsuarioEnum tipoUsuario)
        {
            IUsuario usuario = null;

            switch (tipoUsuario)
            {
                case TipoUsuarioEnum.Cliente:
                    usuario = new Cliente();
                    break;
                case TipoUsuarioEnum.Instructor:
                    usuario = new Instructor();
                    break;
                case TipoUsuarioEnum.Administrador:
                    usuario = new Administrador();
                    break;
                default:
                    break;
            }

            return usuario;
        }
    }
}
