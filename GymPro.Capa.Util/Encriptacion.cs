using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;

namespace GymPro.Capa.Util
{
    /// <summary>
    /// Clase encargada de la encriptacion y desencriptacion de contrasennas u otros datos string
    /// </summary>
    public class Encriptacion
    {
        /// <summary>
        /// Hash para encriptacion y desencriptacion
        /// </summary>
        private const string Hash = "Codificacion_Mensaje_117289_hash";

        /// <summary>
        /// Encripta un string dado utilizando el metodo MD5
        /// </summary>
        /// <param name="pContrasenna">string a encriptar</param>
        /// <returns>encriptacion en Array de bytes</returns>
        public static byte[] EncriptarContrasenna(string pContrasenna)
        {
            byte[] data = UTF8Encoding.UTF8.GetBytes(pContrasenna);

            MD5 md5 = MD5.Create();
            TripleDES tripleDes = TripleDES.Create();

            tripleDes.Key = md5.ComputeHash(UTF8Encoding.UTF8.GetBytes(Hash));
            tripleDes.Mode = CipherMode.ECB;

            ICryptoTransform transform = tripleDes.CreateEncryptor();

            byte[] resultado = transform.TransformFinalBlock(data, 0, data.Length);

            return resultado;
        }

        /// <summary>
        /// Desencripta un Array de bytes dado utilizando el metodo MD5
        /// </summary>
        /// <param name="pContrasennaEncriptada">Array de bytes a desencriptar</param>
        /// <returns>String desencriptado</returns>
        public static string DesencriptarContrasenna(byte[] pContrasennaEncriptada)
        {
            MD5 md5 = MD5.Create();
            TripleDES tripleDes = TripleDES.Create();

            tripleDes.Key = md5.ComputeHash(UTF8Encoding.UTF8.GetBytes(Hash));
            tripleDes.Mode = CipherMode.ECB;

            var transform = tripleDes.CreateDecryptor();

            byte[] resultado = transform.TransformFinalBlock(pContrasennaEncriptada, 0, pContrasennaEncriptada.Length);

            return UTF8Encoding.UTF8.GetString(resultado);
        }
    }
}
