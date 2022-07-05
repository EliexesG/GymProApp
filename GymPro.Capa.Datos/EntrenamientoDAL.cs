using GymPro.Capa.Entidades.Clases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GymPro.Capa.Datos
{
    class EntrenamientoDAL
    {
        public void InsertarEntrenamiento(Entrenamiento pEntrenamineto)
        {
            // Cuando hacemos instancias y se dejan de usar hay un mecanismo que se llama Garbage Collector que limpia esas referencias que no se estan usando
            // Cunado tenemos estatático esas instancias nunca limpian entonces queda en menoria siempre y puede darse un desperdicio. 

            // Aqui va toda logica para insetart el entrenamiento
        }


        public void InsertarDia(int idEntrenamiento, Dia dia)
        {
            // Se inserta el registroen la tabla Dias entrenamiento
        }

    }
}
