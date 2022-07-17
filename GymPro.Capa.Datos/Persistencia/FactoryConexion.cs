using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GymPro.Capa.Datos.Persistencia
{
    public class FactoryConexion
    {
        public static string CreateConnection()
        {
            // Lee la conexion default
            return ConfigurationManager.ConnectionStrings["GymPro.Capa.UI.Properties.Settings.Cadena"].ConnectionString;
        }

        public static string CreateConnection(string nombre)
        {
            // Lee la conexion default
            return ConfigurationManager.ConnectionStrings[nombre].ConnectionString;
        }

        public static string CreateConnection(string pUsuario, String pContrasena)
        {

            StringBuilder conexion = new StringBuilder();
            // Lee la conexion default
            conexion.AppendFormat("{0}", ConfigurationManager.ConnectionStrings["default"].ConnectionString);
            // Agrega al usuario
            conexion.AppendFormat("User Id={0};Password={1}", pUsuario, pContrasena);
            return conexion.ToString();
        }
    }
}
