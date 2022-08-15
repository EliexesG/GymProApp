using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GymPro.Capa.Entidades.Implementaciones
{
    /// <summary>
    /// Entidad que representa un Encabezado de Factura
    /// </summary>
    public class FacturaEncabezado
    {
        public int Codigo { get; set; }
        public string IdentificacionUsuario { get; set; }
        public byte[] CodigoQR { get; set; }
        public DateTime FechaPago { get; set; }
        public DateTime FechaProximoPago { get; set; }
        public double MontoTotal { get; set; }
        public double MontoMulta { get; set; }

        public List<FacturaDetalle> FacturasDetalle { get; set; }
    }
}
