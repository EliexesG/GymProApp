using GymPro.Capa.Entidades.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GymPro.Capa.Entidades.Implementaciones
{
    public class Cliente : IUsuario, IExpedienteUsuario
    {
        // Entidades (clases con solo propiedades y constructor
        // Capa Logica BLL // Operaciones calculos maematicos, entre la capa de datos la capa de interfaz de usuario
        // Capa DATOS // DAL
        #region Propiedades de Usuario
        public string Identificacion { get; set; }
        public string Nombre { get; set; }
        public string Apellidos { get; set; }
        public byte[] Fotografia { get; set; }
        public string Contrasenna { get; set; }
        #endregion

        #region Propiedades de Expediente de Cliente
        public float Peso { get; set; }
        public float Altura { get; set; }
        public float IMC { get; set; }
        public float MetabolismoBasal { get; set; }
        #endregion

        #region Atributos Cliente
        private string Correo { get; set; }
        private string Telefono { get; set; }
        private DateTime FechaNacimiento { get; set; }
        private Genero Genero { get; set; }
        #endregion

    }
}
