using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Globalization;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Reflection;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace GymPro.Capa.Util
{
    /// <summary>
    /// Clase con metodos utiles varios
    /// </summary>
    public class Utilitarios
    {

        //Log4net
        private static readonly log4net.ILog _MyLogControlEventos = log4net.LogManager.GetLogger("MyControlEventos");

        /// <summary>
        /// Activa el Culture Info en base a la moneda del pais CR
        /// </summary>
        public static void CultureInfo()
        {
            // Colocar Cultura Estandar para Costa Rica
            // esto me permite no tener problemas con (.) de los decimales
            CultureInfo Micultura = new CultureInfo("es-CR", false);
            Micultura.NumberFormat.CurrencySymbol = "₡";
            Micultura.NumberFormat.CurrencyDecimalDigits = 2;
            Micultura.NumberFormat.CurrencyDecimalSeparator = ".";
            Micultura.NumberFormat.CurrencyGroupSeparator = ",";
            int[] grupo = new int[] { 3, 3, 3 };
            Micultura.NumberFormat.CurrencyGroupSizes = grupo;
            Micultura.NumberFormat.NumberDecimalDigits = 2;
            Micultura.NumberFormat.NumberGroupSeparator = ",";
            Micultura.NumberFormat.NumberDecimalSeparator = ".";
            Micultura.NumberFormat.NumberGroupSizes = grupo;
            //Micultura.DateTimeFormat.
            Thread.CurrentThread.CurrentCulture = Micultura;
        }

        /// <summary>
        /// Crea un mensaje de error detallado en base a una excepcion SQL
        /// </summary>
        /// <param name="pExcepcion">Excepcion a utilizar</param>
        /// <returns>String con el mensaje detallado de error</returns>
        public static string CreateSQLExceptionsErrorDetails(SqlException pExcepcion)
        {
            StringBuilder msg = new StringBuilder();

            msg.AppendFormat("\n");
            msg.AppendFormat("Lista de Errores \n");
            for (int i = 0; i < pExcepcion.Errors.Count; i++)
            {
                msg.AppendFormat("\t{0} de {1}\n", i + 1, pExcepcion.Errors.Count);
                msg.AppendFormat("\tNumber    : {1}\n", i + 1, pExcepcion.Errors[i].Number);
                msg.AppendFormat("\tLineNumber: {1}\n", i + 1, pExcepcion.Errors[i].LineNumber);
                msg.AppendFormat("\tMessage   : {1}\n", i + 1, pExcepcion.Errors[i].Message);

            }
            msg.AppendFormat("\n");
            msg.AppendFormat("StackTrace     {0}\n", pExcepcion.StackTrace);
            msg.AppendFormat(@"Info de errores para investigar mas https://technet.microsoft.com/en-us/library/cc645603(v=sql.105).aspx");
            return msg.ToString();
        }

        /// <summary>
        /// Crea un mensaje de error detallado en base a una excepcion SQL, un comando SQL y un metodo base
        /// </summary>
        /// <param name="pMethodBase">Metodo base a utilizar</param>
        /// <param name="pCommand">Comando SQL a utilizar</param>
        /// <param name="pExcepcion">Excepcion a utilizar</param>
        /// <returns>String con el mensaje detallado de error</returns>
        public static string CreateSQLExceptionsErrorDetails(MethodBase pMethodBase, IDbCommand pCommand, SqlException pExcepcion)
        {
            StringBuilder msg = new StringBuilder();

            msg.AppendFormat("\nClase: {0}\n", pMethodBase.DeclaringType);
            msg.AppendFormat("Method: {0}\n", pMethodBase.Name);
            msg.AppendFormat("\n");
            msg.AppendFormat("Lista de Errores \n");
            for (int i = 0; i < pExcepcion.Errors.Count; i++)
            {
                msg.AppendFormat("\t{0} de {1}\n", i + 1, pExcepcion.Errors.Count);
                msg.AppendFormat("\tNumber    : {1}\n", i + 1, pExcepcion.Errors[i].Number);
                msg.AppendFormat("\tLineNumber: {1}\n", i + 1, pExcepcion.Errors[i].LineNumber);
                msg.AppendFormat("\tMessage   : {1}\n", i + 1, pExcepcion.Errors[i].Message);
            }
            msg.AppendFormat("\n");
            msg.AppendFormat("StackTrace     {0}\n", pExcepcion.StackTrace);
            msg.AppendFormat("SQL donde ocurrió el error: {0}\n", pCommand != null ? pCommand.CommandText : "N/A");
            msg.AppendFormat("Info de errores para investigar mas {0}\n", @"https://technet.microsoft.com/en-us/library/cc645603(v=sql.105).aspx");
            msg.AppendFormat("{0}\n", "".PadRight(100, '-'));
            return msg.ToString();
        }

        /// <summary>
        /// Crea un mensaje de error detallado en base a una excepcion generica y un metodo base
        /// </summary>
        /// <param name="pMethodBase">Metodo base a utilizar</param>
        /// <param name="pExcepcion">Excepcion a utilizar</param>
        /// <returns>String con el mensaje detalledo de error</returns>
        public static string CreateGenericErrorExceptionDetail(MethodBase pMethodBase, Exception pExcepcion)
        {
            StringBuilder msg = new StringBuilder();
            msg.AppendFormat("\nClase    :{0}\n", pMethodBase.DeclaringType);
            msg.AppendFormat("Method     :{0}\n", pMethodBase.Name);
            msg.AppendFormat("Message    :{0}\n", pExcepcion.Message);
            msg.AppendFormat("Source     :{0}\n", pExcepcion.Source);
            msg.AppendFormat("StackTrace :{0}\n", pExcepcion.StackTrace);
            msg.AppendFormat("{0}\n", "".PadRight(100, '-'));
            return msg.ToString();
        }

        /// <summary>
        /// Crea un mensaje de error en espannol en base a la Excepcion SQL
        /// </summary>
        /// <param name="pSqlExcepcion">Excepcion SQL a traducir</param>
        /// <returns>String con el error en espanno</returns>
        public static string GetCustomErrorByNumber(SqlException pSqlExcepcion)
        {
            string msg = "\n";

            switch (pSqlExcepcion.Number)
            {
                case 17:
                    msg += "Error el servidor '" + pSqlExcepcion.Server + "' no existe, por favor verifique el nombre ";
                    break;
                case 53:
                    msg += "Error no se logra conectar al servidor, puede ser porque estén los servicios no activos o el nombre del servidor esté mal escrito ";
                    break;
                case 109:
                    msg += "Error hay más columnas en el INSERT que los parámetros que se envían ";
                    break;
                case 110:
                    msg += "Error hay menos columnas en el INSERT que los parámetros que se envían ";
                    break;
                case 113:
                    msg += "Error con comentarios ";
                    break;
                case 137:
                    msg = $"Error al declarar variables que se pasan al SQL. Mensaje de la BD {pSqlExcepcion.Message} ";
                    break;
                case 156:
                    msg += "Error de sintaxis del SQL ";
                    break;
                case 207:
                    msg += "Error un campo de la tabla NO existe ";
                    break;
                case 208:    //Invalid object name '%ls'."
                    msg += "Error el nombre del objeto de la base de datos NO correcto o no EXISTE ";
                    break;
                case 547:
                    msg += "Error de Integridad, intentó  borrar o salvar un registro que tiene un dato Padre referenciado ";
                    break;
                case 2627:    //Login failed for user '%ls'. Reason: Not associated with a trusted SQL Server connection.
                    msg += "Error el código que está intentando salvar YA EXISTE ";
                    break;
                case 2812:
                    msg += "Error esta intentando invocar un procedimiento almacenado que NO EXISTE ";
                    break;
                case 4060:    //Cannot open database requested in login '%.*ls'. Login fails.
                    msg += "No se puede acceder la base de datos, (estará en línea, bien configurada?) ";
                    break;
                case 18452:    //Login failed for user '%ls'. Reason: Not associated with a trusted SQL Server connection.
                    msg += "Error especifique un usuario y password ";
                    break;
                case 18456: //Login failed for user '%ls'.
                    msg += "Error el usuario o password es incorrecto ";
                    break;

                default:
                    msg = pSqlExcepcion.Message;
                    break;
            }


            return msg;

        }

        /// <summary>
        /// Envia un correo en base a su receptor, el tema, mensaje y la ruta donde se encuentra el archivo a utilizar como Attachment
        /// </summary>
        /// <param name="pReceptor">Receptor a utilizar</param>
        /// <param name="pTema">Tema a utilizar</param>
        /// <param name="pMensaje">Mensaje a utilizar</param>
        /// <param name="pAttachRuta">Ruta del Attachment a utilizar</param>
        public static void EnviarCorreo(string pReceptor, string pTema, string pMensaje, string pAttachRuta)
        {
            try
            {

                string cuenta = "gympro001mensajes@gmail.com";
                string contrasenaGenerada = "bxvuqmknplxzhgvm";

                MailMessage emailEnviar = new MailMessage();
                emailEnviar.IsBodyHtml = true;
                emailEnviar.Subject = pTema;
                emailEnviar.Body = pMensaje;
                emailEnviar.From = new MailAddress(cuenta);
                emailEnviar.To.Add(pReceptor);

                SmtpClient smtp = new SmtpClient("smtp.gmail.com");
                smtp.Port = 587;
                smtp.Credentials = new NetworkCredential(cuenta, contrasenaGenerada);
                smtp.EnableSsl = true;

                Attachment attachment = new Attachment(pAttachRuta);
                emailEnviar.Attachments.Add(attachment);

                smtp.Send(emailEnviar);

            }
            catch(Exception er)
            {
                StringBuilder msg = new StringBuilder();
                msg.AppendFormat(Utilitarios.CreateGenericErrorExceptionDetail(MethodBase.GetCurrentMethod(), er));
                _MyLogControlEventos.ErrorFormat("Error {0}", msg.ToString());

                throw er;
            }
        }

        /// <summary>
        /// Envia un correo en base a su receptor, el tema y su mensaje 
        /// </summary>
        /// <param name="pReceptor">Receptor a utilizar</param>
        /// <param name="pTema">Tema a utilizar</param>
        /// <param name="pMensaje">Mensaje a utilizar</param>
        public static void EnviarCorreo(string pReceptor, string pTema, string pMensaje)
        {
            try
            {
                string cuenta = "gympro001mensajes@gmail.com";
                string contrasenaGenerada = "bxvuqmknplxzhgvm";

                MailMessage emailEnviar = new MailMessage();
                emailEnviar.IsBodyHtml = true;
                emailEnviar.Subject = pTema;
                emailEnviar.Body = pMensaje;
                emailEnviar.From = new MailAddress(cuenta);
                emailEnviar.To.Add(pReceptor);

                SmtpClient smtp = new SmtpClient("smtp.gmail.com");
                smtp.Port = 587;
                smtp.Credentials = new NetworkCredential(cuenta, contrasenaGenerada);
                smtp.EnableSsl = true;

                smtp.Send(emailEnviar);
            }
            catch (Exception er)
            {
                StringBuilder msg = new StringBuilder();
                msg.AppendFormat(Utilitarios.CreateGenericErrorExceptionDetail(MethodBase.GetCurrentMethod(), er));
                _MyLogControlEventos.ErrorFormat("Error {0}", msg.ToString());

                throw er;
            }
        }
    }
}
