﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GymPro.Capa.Entidades.Interfaces
{
   public interface IUsuario
    {
        string Identificacion { get; set; }
        string Nombre { get; set; }
        string Apellido1 { get; set; }
        string Apellido2 { get; set; }
        byte[] Fotografia { get; set; }
        int CodigoTipoUsuario { get; set; }
        string Contrasenna { get; set; }
    }
}
