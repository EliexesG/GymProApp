using GymPro.Capa.Entidades.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GymPro.Capa.Datos.Interfaces
{
    public interface IUsuarioDAL
    {
        void InsertarUsuario(IUsuario pUsuario);
        void ModificarUsuario(IUsuario pUsuario);
        void EliminarUsuario(string pIdentificacionUsuario);
        void ActivarUsuario(string pIdentificacionUsuario);
        List<IUsuario> ObtenerUsuarioActivoTodos();
        List<IUsuario> ObtenerUsuarioInactivoTodos();
        IUsuario ObtenerUsuarioIdentificacion(string pIdentificacionUsuario);

    }
}
