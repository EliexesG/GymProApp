using GymPro.Capa.Entidades.Implementaciones;
using System.Collections.Generic;

namespace GymPro.Capa.Logica.BLL.Interfaces
{
    public interface ITipoUsuarioBLL
    {
        TipoUsuario ObtenerTipoUsuarioId(int pCodigo);
        List<TipoUsuario> ObtenerTipoUsuarioTodos();
    }
}