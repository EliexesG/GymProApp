using GymPro.Capa.Entidades.Implementaciones;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GymPro.Capa.Logica.BLL.Interfaces
{
    public interface IExpedienteUsuarioBLL
    {
        void InsertarExpedienteUsuario(ExpedienteUsuario pExpediente);
        void ModificarExpedienteUsuario(ExpedienteUsuario pExpediente);
        void EliminarExpedienteUsuario(DateTime pFecha, string pIdentificacionUsuario);
        List<ExpedienteUsuario> ObtenerExpedienteUsuarioTodos();
        ExpedienteUsuario ObtenerExpedienteUsuarioId(DateTime pFecha, string pIdentificacionUsuario);
        List<ExpedienteUsuario> ObtenerExpedienteUsuarioIdentificacionUsuario(string pIdentificacionUsuario);
    }
}
