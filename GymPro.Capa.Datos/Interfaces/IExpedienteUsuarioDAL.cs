using GymPro.Capa.Entidades.Implementaciones;
using System;
using System.Collections.Generic;

namespace GymPro.Capa.Datos.Interfaces
{
    public interface IExpedienteUsuarioDAL
    {
        void InsertarExpedienteUsuario(ExpedienteUsuario pExpediente);
        void ModificarExpedienteUsuario(ExpedienteUsuario pExpediente);
        void EliminarExpedienteUsuario(DateTime pFecha, string pIdentificacionUsuario);
        List<ExpedienteUsuario> ObtenerExpedienteUsuarioTodos();
        ExpedienteUsuario ObtenerExpedienteUsuarioId(DateTime pFecha, string pIdentificacionUsuario);
        List<ExpedienteUsuario> ObtenerExpedienteUsuarioIdentificacionUsuario(string pIdentificacionUsuario);
    }
}