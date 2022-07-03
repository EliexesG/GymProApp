using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GymPro.Capa.Entidades.ExcepcionesCustom
{
    class ValorNoAsignadoException : ApplicationException
    {

        public ValorNoAsignadoException(string mensaje) : base(mensaje)
        {

        }

        public ValorNoAsignadoException() : base ("Valor no ha sido asignado aún")
        {

        }

    }
}
