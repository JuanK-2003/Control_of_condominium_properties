using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3_repaso.Classs
{
    class Report_Condominium : Report
    {
        public double Manteinance { get; set; }

        public Report_Condominium()
        {
        }

        public Report_Condominium(string ownerID, string ownerName, string ownerLastName,
            int propertyNumber, double manteinance)
        {
            this.ownerID = ownerID;
            this.ownerName = ownerName;
            this.ownerLastName = ownerLastName;
            this.propertyNumber = propertyNumber;
            this.Manteinance = manteinance;
        }
    }
}
