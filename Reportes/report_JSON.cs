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
    class report_JSON
    {
        public static void SaveReportsByPerson(IEnumerable<Report_Person> reports)
        {
            string fileName = fileName = FileNames.ReportsByOwner;

            if (File.Exists(fileName))
            {
                File.Delete(fileName);
            }

            using (StreamWriter sw = new StreamWriter(fileName))
            {
                sw.WriteAsync(JsonConvert.SerializeObject(reports));
            }
        }

        public static void SaveReportsByProperty(IEnumerable<Report_Condominium> reports)
        {
            string fileName = fileName = FileNames.ReportsByProperty;

            if (File.Exists(fileName))
            {
                File.Delete(fileName);
            }

            using (StreamWriter sw = new StreamWriter(fileName))
            {
                sw.WriteAsync(JsonConvert.SerializeObject(reports));
            }
        }

    }
}
