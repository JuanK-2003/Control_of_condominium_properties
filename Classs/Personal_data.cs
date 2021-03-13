using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3_repaso.Classs
{
    class Personal_data
    {
        string ID;
        string name;
        string lastName;

        public Personal_data()
        {
        }

        public Personal_data(string iD, string name, string lastName)
        {
            ID1 = iD;
            this.Name = name;
            this.LastName = lastName;
        }

        public string ID1 { get => ID; set => ID = value; }
        public string Name { get => name; set => name = value; }
        public string LastName { get => lastName; set => lastName = value; }
    }
}
