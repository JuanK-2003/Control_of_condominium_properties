using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3_repaso.Classs
{
    class Report_Person : Report
    {
        public double totalManteinance { get; set; }
        public int quantyProperties { get; set; }
        public double averageProperties { get; set; }

        public Report_Person()
        {
        }
        public Report_Person(string ownerID, string ownerName, string ownerLastName, int propertyNumber,
            double totalManteinance, int quantyProperties, double averageProperties)
        {
            this.ownerID = ownerID;
            this.ownerName = ownerName;
            this.ownerLastName = ownerLastName;
            this.propertyNumber = propertyNumber;
            this.totalManteinance = totalManteinance;
            this.quantyProperties = quantyProperties;
            this.averageProperties = averageProperties;
        }
    }
}
