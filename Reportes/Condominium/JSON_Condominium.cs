using Lab3_repaso.Classs;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Lab3_repaso.Reportes.FileNames;

namespace Lab3_repaso.Reportes.Condominium
{
    class JSON_Condominium
    {
        public static IEnumerable<Condominium_data> GetPropertiesOrIEnumerableOfProperty()
        {
            var properties = new List<Condominium_data>();
            if (File.Exists(PropertyFile))
            {
                using (StreamReader sr = new StreamReader(PropertyFile))
                {
                    properties = JsonConvert.DeserializeObject<List<Condominium_data>>(sr.ReadToEnd());
                }
            }
            return properties;
        }
    }
}
