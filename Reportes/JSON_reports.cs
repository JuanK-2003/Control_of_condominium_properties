using Lab3_repaso.Classs;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3_repaso.Reportes
{
    class JSON_reports
    {
        public static IEnumerable<Report_Person> GetReportsOrIEnumerableOfReportsByPerson()
        {
            var reports = new List<Report_Person>();
            string fileName = FileNames.ReportsByOwner;
            if (File.Exists(fileName))
            {
                using (StreamReader sr = new StreamReader(fileName))
                {
                    reports = JsonConvert.DeserializeObject<List<Report_Person>>(sr.ReadToEnd());
                }
            }

            return reports;
        }

        public static IEnumerable<Report_Condominium> GetReportsOrIEnumerableOfReportsByProperty()
        {
            var reports = new List<Report_Condominium>();
            string fileName = FileNames.ReportsByProperty;

            if (File.Exists(fileName))
            {
                using (StreamReader sr = new StreamReader(fileName))
                {
                    reports = JsonConvert.DeserializeObject<List<Report_Condominium>>(sr.ReadToEnd());
                }
            }

            return reports;
        }
    }
}
