using GymPro.Capa.Entidades.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GymPro.Capa.Entidades.Clases
{
    class Administrador : IUsuario
    {
        #region Propiedades de Usuario
        public string Identificacion { get; set; }
        public string Nombre { get; set; }
        public string Apellidos { get; set; }
        public byte[] Fotografia { get; set; }
        public string Contrasenna { get; set; }
        #endregion
    }
}
