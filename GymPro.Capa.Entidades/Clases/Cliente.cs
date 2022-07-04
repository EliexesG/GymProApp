using GymPro.Capa.Entidades.ExcepcionesCustom;
using GymPro.Capa.Entidades.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GymPro.Capa.Entidades.Clases
{
    class Cliente : IUsuario, IEstadoCliente
    {
        #region Propiedades de Usuario
        public string Identificacion { get; set; }
        public string Nombre { get; set; }
        public string Apellidos { get; set; }
        public byte[] Fotografia { get; set; }
        public string Contrasenna { get; set; }
        #endregion

        #region Propiedades de Estado de Cliente
        public float Peso { get; set; }
        public float Altura { get; set; }
        public float IMC { get; set; }
        public float MetabolismoBasal { get; set; }
        #endregion

        #region Atributos Cliente
        private string Correo;
        private int Telefono;
        private DateTime FechaNacimiento;
        private char Genero;
        #endregion

        #region Asignacion Atributos
        public void AsignarCorreo(string correo)
        {
            Correo = correo;
        }

        public void AsignarTelefono(int telefono)
        {
            Telefono = telefono;
        }

        public void AsignarFechaNacimiento(DateTime fecha)
        {
            FechaNacimiento = fecha;
        }

        public void AsignarGenero(char genero)
        {
            Genero = genero;
        }
        #endregion

        #region Obtencion de Atributos
        public string ObtenerCorreo()
        {
            if (string.IsNullOrEmpty(Correo))
            {
                throw new ValorNoAsignadoException("El correo no ha sido asignado aún");
            }

            return Correo;
        }

        public int ObtenerTelefono()
        {
            if(Telefono == 0)
            {
                throw new ValorNoAsignadoException("El teléfono no ha sido asignado aún");
            }

            return Telefono;
        }

        public DateTime ObtenerFechaNacimiento()
        {
            if(FechaNacimiento == null)
            {
                throw new ValorNoAsignadoException("La fecha de nacimiento no ha sido asignada aún");
            }

            return FechaNacimiento;
        }

        public char ObtenerGenero()
        {
            if (char.Equals(''))
            {
                throw new ValorNoAsignadoException("La fecha de nacimiento no ha sido asignada aún");
            }

            return Genero;
        }
        #endregion
    }
}
