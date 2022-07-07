using GymPro.Capa.Entidades.Interfaces;
using System.Collections.Generic;

namespace GymPro.Capa.Logica.BLL.Interfaces
{
    interface IUsuarioBLL
    {
        void ActualizarUsuario(IUsuario pUsuario);
        void EliminarUsuarioPorID(string pId);
        void InsertarUsuario(IUsuario pUsuario);
        List<IUsuario> SeleccionarTodosUsuarios();
        IUsuario SeleccionarUsuarioPorID(string pId);
    }
}