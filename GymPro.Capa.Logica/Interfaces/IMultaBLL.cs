using GymPro.Capa.Entidades.Implementaciones;

namespace GymPro.Capa.Logica.Interfaces
{
    public interface IMultaBLL
    {
        void ModificarMulta(Multa pMulta);
        Multa ObtenerMulta();
    }
}