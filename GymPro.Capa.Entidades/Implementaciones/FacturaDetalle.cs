using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GymPro.Capa.Entidades.Implementaciones
{
    /// <summary>
    /// Entidad que representa un Detalle de Factura
    /// </summary>
    public class FacturaDetalle
    {
        public int CodigoFactura { get; set; }
        public int CodigoServicio { get; set; }

        public Servicio _Servicio { get; set; }
    }
}
