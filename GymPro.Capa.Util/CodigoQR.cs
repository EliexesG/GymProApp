using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using MessagingToolkit.QRCode.Codec;

namespace GymPro.Capa.Util
{
    /// <summary>
    /// Clase encargada de generar codigos QR
    /// </summary>
    public class CodigoQR
    {

        //Log4net
        private static readonly log4net.ILog _MyLogControlEventos = log4net.LogManager.GetLogger("MyControlEventos");

        /// <summary>
        /// Crea un codigo QR en base al codigo dado por parametro
        /// </summary>
        /// <param name="codigo">Codigo a convertir</param>
        /// <returns>Array de bytes con los bytes del codigo QR</returns>
        public static byte[] ObtenerCodigoQR(int codigo)
        {
            try
            {
                string toenc = codigo.ToString();

                MessagingToolkit.QRCode.Codec.QRCodeEncoder qe = new MessagingToolkit.QRCode.Codec.QRCodeEncoder();

                qe.QRCodeEncodeMode = QRCodeEncoder.ENCODE_MODE.BYTE;

                qe.QRCodeErrorCorrect = QRCodeEncoder.ERROR_CORRECTION.L; // - Using LOW for more storage

                qe.QRCodeVersion = 1;

                System.Drawing.Bitmap bm = qe.Encode(toenc);

                ImageConverter _imageConverter = new ImageConverter();
                return (byte[])_imageConverter.ConvertTo(bm, typeof(byte[]));
            }
            catch(Exception er)
            {
                StringBuilder msg = new StringBuilder();
                msg.AppendFormat(Utilitarios.CreateGenericErrorExceptionDetail(MethodBase.GetCurrentMethod(), er));
                _MyLogControlEventos.ErrorFormat("Error {0}", msg.ToString());

                throw er;
            }
            
        }

    }
}
