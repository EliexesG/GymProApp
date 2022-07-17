using GymPro.Capa.Entidades.Interfaces;
using System.Collections.Generic;

namespace GymPro.Capa.Logica.BLL.Interfaces
{
    public interface IUsuarioBLL
    {
        void EliminarUsuario(string pIdentificacionUsuario);
        void InsertarUsuario(IUsuario pUsuario);
        void ModificarUsuario(IUsuario pUsuario);
        IUsuario ObtenerUsuarioIdentificacion(string pIdentificacionUsuario);
        List<IUsuario> ObtenerUsuarioTodos();
    }
}