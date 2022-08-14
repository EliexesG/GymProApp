using GymPro.Capa.Entidades.Implementaciones;

namespace GymPro.Capa.Datos.Interfaces
{
    public interface IMultaDAL
    {
        void ModificarMulta(Multa pMulta);
        Multa ObtenerMulta();
    }
}