using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2Version
{
    class Student : Person, IStudent
    {
        public List<Kurs> KursLista = new List<Kurs>();
        public List<Uppgift> Uppgift = new List<Uppgift>();

        private string _studentId;
        private string _kursNamn;

        public string StudentId
        {
            get { return _studentId; }
            set { _studentId = value; }
        }

        public string KursName
        {
            get { return _kursNamn; }
            set { _kursNamn = value; }
        }

        public Student() : base()
        {

        }
        //konstruktor som tar in värden
        public Student(string name, string personNr, string studId) : base(name, personNr)
        {
            Name = name;
            PersonNr = personNr;
            StudentId = studId;
        }

        public void LäggTillStudent(string n, string p, string id)
        {
            Student s = new Student(n, p, id);
        }

        public void LäggTillKurs(Kurs k)
        {
            KursLista.Add(k);
        }

        public void TaBortKurs(int index)
        {
            KursLista.RemoveAt(index);
        }

        public void LäggTillUppgift(Uppgift u)
        {
            Uppgift.Add(u);
        }

        public void TaBortUppgift(int index)
        {
            Uppgift.RemoveAt(index);
        }
    }
}
