using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GymPro.Capa.Entidades.Implementaciones
{
    /// <summary>
    /// Entidad que representa un Expediente de un Usuario
    /// </summary>
    public class ExpedienteUsuario
    {
        #region Propiedades de Expediente de Cliente
        public DateTime Fecha { get; set; }
        public string IdentificacionUsuario { get; set; }
        public double Peso { get; set; }
        public int Altura { get; set; }
        public double IMC { get; set; }
        public double MetabolismoBasal { get; set; }
        #endregion
    }
}
