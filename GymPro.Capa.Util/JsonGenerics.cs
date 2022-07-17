using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace GymPro.Capa.Util
{
    public class JsonGenerics<T>
    {
        public static T JsonAObjeto(string pJson)
        {
            return JsonConvert.DeserializeObject<T>(pJson);
        }
    }
}
