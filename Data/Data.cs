using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lab3_repaso.Reportes.Person;
using Lab3_repaso.Reportes.Condominium;
using Lab3_repaso.Reportes;
using Lab3_repaso.Classs;
using Lab3_repaso.Reports;

namespace Lab3_repaso.Data
{
    class Data
    {
        public static List<Personal_data> personals = JSON_Personal.GetPersonsOrNewIEnumerableOfPersons().ToList();
        public static List<Condominium_data> condominia = JSON_Condominium.GetPropertiesOrIEnumerableOfProperty().ToList();
        public static List<Report_Person> report_People = JSON_reports.GetReportsOrIEnumerableOfReportsByPerson().ToList();
        public static List<Report_Condominium> report_Condominia = JSON_reports.GetReportsOrIEnumerableOfReportsByProperty().ToList();

        public static void generateReports()
        {
            //Reports are generated here
            report_People = Reports.Reporter.MakeReportsByPerson(personals, condominia).ToList();
            report_Condominia = Reports.Reporter.MakeReportsByProperty(personals, condominia).ToList();
        }
        public static void savePerson()
        {
            personal_JSON.Save(personals);
        }
        public static void saveCondominium()
        {
            Condominium_JSON.Save(condominia);
        }
        public static void saveReports()
        {
            //Reports are saved
            generateReports();
            report_JSON.SaveReportsByPerson(report_People);
            report_JSON.SaveReportsByProperty(report_Condominia);
        }

        public static void saveAll()
        {
            //All data is saved
            savePerson();
            saveCondominium();
            saveReports();
        }
    }
}
