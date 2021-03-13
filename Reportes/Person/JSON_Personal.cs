using Lab3_repaso.Classs;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3_repaso.Reportes.Person
{
    class JSON_Personal
    {
        public static IEnumerable<Personal_data> GetPersonsOrNewIEnumerableOfPersons()
        {
            var Persons = new List<Personal_data>();
            if (File.Exists(FileNames.PersonFile))
            {
                using (StreamReader sr = new StreamReader(FileNames.PersonFile))
                {
                    Persons = JsonConvert.DeserializeObject<List<Personal_data>>(sr.ReadToEnd());
                }
            }
            return Persons;
        }
    }
}
