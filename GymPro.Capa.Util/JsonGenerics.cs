using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace GymPro.Capa.Util
{
    /// <summary>
    /// Clase encargada de la conversion de JSONs a objetos y viceversa
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class JsonGenerics<T>
    {
        /// <summary>
        /// Convierte un string representando un JSON a objeto de tipo <typeparamref name="T"/>
        /// </summary>
        /// <param name="pJson">JSON a convertir a objeto de tipo <typeparamref name="T"/></param>
        /// <returns>Objeto de tipo <typeparamref name="T"/></returns>
        public static T JsonAObjeto(string pJson)
        {
            return JsonConvert.DeserializeObject<T>(pJson);
        }

        /// <summary>
        /// Convierte un objeto de tipo <typeparamref name="T"/> y lo convierte a un String representando un JSON
        /// </summary>
        /// <param name="pObjeto">Objeto de tipo <typeparamref name="T"/> a convertir a JSON</param>
        /// <returns>String representando el JSON</returns>
        public static string ObjetoAJSON(T pObjeto)
        {
            return JsonConvert.SerializeObject(pObjeto);
        }
    }
}
