using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2Version
{
    class Lärare : Person, ILärare
    {
        public List<Kurs> lKurs = new List<Kurs>();
        public List<Uppgift> luppgift = new List<Uppgift>();

        private string _lärarId;

        public string LärarID
        {
            get { return _lärarId; }
            set { _lärarId = value; }
        }

        public Lärare() : base()
        {

        }
        //konstruktor som tar in värden
        public Lärare(string name, string personNr, string lärarId) : base(name, personNr) 
        {
            Name = name;
            PersonNr = personNr;
            LärarID = lärarId;
        }
    }
}
