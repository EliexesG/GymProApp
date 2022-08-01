using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MessagingToolkit.QRCode.Codec;

namespace GymPro.Capa.Util
{
    public class CodigoQR
    {

        public static byte[] ObtenerCodigoQR(int codigo)
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

    }
}
