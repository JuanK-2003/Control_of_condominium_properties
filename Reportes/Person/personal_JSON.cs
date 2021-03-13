using Lab3_repaso.Classs;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Lab3_repaso.Reportes.FileNames;

namespace Lab3_repaso.Reportes.Person
{
    class personal_JSON
    {
        public static void Save(IEnumerable<Personal_data> people)
        {

            if (File.Exists(PersonFile))
            {
                File.Delete(PersonFile);
            }

            using (StreamWriter sw = new StreamWriter(PersonFile))
            {
                sw.Write(JsonConvert.SerializeObject(people));
            }

        }
    }
}
