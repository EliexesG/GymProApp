using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;

namespace GymPro.Capa.Util
{
    public class Encriptacion
    {
        private const string Hash = "Codificacion_Mensaje_117289_hash";

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

            public static string DesencriptarContrasenna(byte[] pContrasennaEncriptada)
            {
                MD5 md5 = MD5.Create();
                TripleDES tripleDes = TripleDES.Create();

                tripleDes.Key = md5.ComputeHash(UTF8Encoding.UTF8.GetBytes(Hash));
                tripleDes.Mode = CipherMode.ECB;

                ICryptoTransform transform = tripleDes.CreateDecryptor();

                byte[] resultado = transform.TransformFinalBlock(pContrasennaEncriptada, 0, pContrasennaEncriptada.Length);

                return UTF8Encoding.UTF8.GetString(resultado);
            }
    }
}
