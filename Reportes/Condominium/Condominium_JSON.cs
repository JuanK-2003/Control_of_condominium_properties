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
    class Condominium_JSON
    {
        public static void Save(IEnumerable<Condominium_data> properties)
        {
            if (File.Exists(PropertyFile))
            {
                File.Delete(PropertyFile);
            }
            using (StreamWriter sr = new StreamWriter(PropertyFile))
            {
                sr.WriteAsync(JsonConvert.SerializeObject(properties));
            }
        }
    }
}
