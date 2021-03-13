using Lab3_repaso.Classs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3_repaso.Reports
{
    class Reporter
    {
        public static IEnumerable<Report_Condominium> MakeReportsByProperty(IEnumerable<Personal_data> people, IEnumerable<Condominium_data> properties)
        {
            var reportsByProperty = new List<Report_Condominium>();
            foreach (var person in people)
            {
                var propertiesOwned = properties.Where(property => property.OwnerID.Equals(person.ID1)).ToList();
                foreach (var property in propertiesOwned)
                {
                    reportsByProperty.Add(
                        new Report_Condominium(
                            person.ID1,
                            person.Name,
                            person.LastName,
                            property.HouseNumber,
                            property.Maintenance
                            )
                        );
                }
            }
            return reportsByProperty;
        }

        public static IEnumerable<Report_Person> MakeReportsByPerson(IEnumerable<Personal_data> people, IEnumerable<Condominium_data> properties)
        {
            var reportsByProperty = new List<Report_Person>();
            foreach (var person in people)
            {
                var propertiesOwned = properties.Where(property => property.OwnerID.Equals(person.ID1)).ToList();
                double totalFee = propertiesOwned.Sum(p => p.Maintenance);
                int totalProperties = properties.Count();
                double averageFee = Math.Round(totalFee / totalProperties, 2);
                foreach (var property in propertiesOwned)
                {
                    reportsByProperty.Add(
                        new Report_Person(
                            person.ID1,
                            person.Name,
                            person.LastName,
                            property.HouseNumber,
                            totalFee,
                            totalProperties,
                            averageFee
                            )
                        );
                }
            }
            return reportsByProperty;
        }
    }
}
