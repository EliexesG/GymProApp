﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GymPro.Capa.Entidades.Implementaciones
{
    /// <summary>
    /// Entidad que representa un Entrenamiento
    /// </summary>
    public class Entrenamiento
    {
        public int Codigo { get; set; }
        public string IdentificacionCliente { get; set; }
        public string IdentificacionEntrenador { get; set; }
        public string Nombre { get; set; }

        public List<EjercicioEnEntrenamiento> EjerciciosEnEntrenamiento { get; set; }
        public List<DiaEntrenamiento> DiasEntrenamiento { get; set; }
    }
}
