using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GymPro.Capa.Entidades.Implementaciones
{
    public class FacturaEncabezado
    {
        public int Codigo { get; set; }
        public string IdentificacionUsuario { get; set; }
        public byte[] CodigoQR { get; set; }
        public DateTime FechaPago { get; set; }
        public DateTime FechaProximoPago { get; set; }
        public float MontoTotal { get; set; }
        public float MontoMulta { get; set; }
    }
}
