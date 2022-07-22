using GymPro.Capa.Entidades.Implementaciones;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GymPro.Capa.Datos.Interfaces
{
    public interface IControlIngresoEgresoDAL
    {
        void InsertarIngreso(ControlIngresoEgreso pControlIngresoEgreso);
        void ModificarEgreso(ControlIngresoEgreso pControlIngresoEgreso);
        List<ControlIngresoEgreso> ObtenerControlIngresoEgresoTodos();
        List<ControlIngresoEgreso> ObtenerControlIngresoEgresoIdentificacionUsuario(string pIdentificacionUsuario);
        ControlIngresoEgreso ObtenerControlIngresoEgresoUltimoIdentificacionUsuario(string pIdentificacionUsuario);

    }
}
