using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2Version
{
    abstract class Person : IPerson
    {
        private string _name;
        private string _personNr;

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        public string PersonNr
        {
            get { return _personNr; }
            set { _personNr = value; }
        }

        public Person(string name, string personNr)
        {
            this.Name = name;
            this.PersonNr = personNr;
        }

        public Person()
        {
        }
    }
}
