﻿using GymPro.Capa.Entidades.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GymPro.Capa.Entidades.Implementaciones
{
    /// <summary>
    /// Entidad que representa un Administrador
    /// </summary>
    public class Administrador : IUsuario
    {
        #region Propiedades de Usuario
        public string Identificacion { get; set; }
        public string Nombre { get; set; }
        public string Apellido1 { get; set; }
        public string Apellido2 { get; set; }
        public byte[] Fotografia { get; set; }
        public int CodigoTipoUsuario { get; set; }
        public string Contrasenna { get; set; }
        public TipoUsuario _TipoUsuario { get; set; }
        #endregion
    }
}
