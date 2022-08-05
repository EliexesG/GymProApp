using GymPro.Capa.Entidades.Implementaciones;
using System.Collections.Generic;

namespace GymPro.Capa.Logica.BLL.Interfaces
{
    public interface IControlIngresoEgresoBLL
    {
        void InsertarIngreso(ControlIngresoEgreso pControlIngresoEgreso);
        void ModificarEgreso(ControlIngresoEgreso pControlIngresoEgreso);
        List<ControlIngresoEgreso> ObtenerControlIngresoEgresoIdentificacionUsuario(string pIdentificacionUsuario);
        List<ControlIngresoEgreso> ObtenerControlIngresoEgresoTodos();
        ControlIngresoEgreso ObtenerControlIngresoEgresoUltimoIdentificacionUsuario(string pIdentificacionUsuario);
    }
}