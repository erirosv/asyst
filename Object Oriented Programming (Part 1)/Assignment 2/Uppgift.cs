using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2Version
{
    class Uppgift : IUppgift
    {
        private string _KursID;
        public string KursID
        {
            get { return _KursID; }
            set { _KursID = value; }
        }

        private string _upgName;
        private string _upgBetyg;
        private string _sid; 


        // Getter och setter 
        public string UpgName
        {
            get { return _upgName; }
            set { _upgName = value; }
        }

        public string UpgBetyg
        {
            get { return _upgBetyg; }
            set { _upgBetyg = value; }
        }

        public string Sid
        {
            get { return _sid; }
            set { _sid = value; }
        }

        // Konstrukyors
        public Uppgift() : base()
        {

        }

        public Uppgift(string name)
        {
            UpgName = name;
        }

        public void LäggTillUppgift(Uppgift u)
        {

        }
    }
}
