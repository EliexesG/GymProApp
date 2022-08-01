using GymPro.Capa.Entidades.Interfaces;
using System;
using System.Collections.Generic;

namespace GymPro.Capa.Logica.BLL.Interfaces
{
    public interface IUsuarioBLL
    {
        void InsertarUsuario(IUsuario pUsuario);
        void ModificarUsuario(IUsuario pUsuario);
        void EliminarUsuario(string pIdentificacionUsuario);
        void ActivarUsuario(string pIdentificacionUsuario);
        List<IUsuario> ObtenerUsuarioActivoTodos();
        List<IUsuario> ObtenerUsuarioInactivoTodos();
        IUsuario ObtenerUsuarioIdentificacion(string pIdentificacionUsuario);
        int CalcularEdadUsuario(DateTime pFechaNacimiento);
    }
}