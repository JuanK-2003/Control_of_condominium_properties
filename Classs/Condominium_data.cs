using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3_repaso.Classs
{
    class Condominium_data
    {
        string ownerID;
        int houseNumber;
        double maintenance;

        public Condominium_data()
        {
        }

        public Condominium_data(string ownerID, int houseNumber, double maintenance)
        {
            this.OwnerID = ownerID;
            this.HouseNumber = houseNumber;
            this.Maintenance = maintenance;
        }

        public string OwnerID { get => ownerID; set => ownerID = value; }
        public int HouseNumber { get => houseNumber; set => houseNumber = value; }
        public double Maintenance { get => maintenance; set => maintenance = value; }
    }
}
