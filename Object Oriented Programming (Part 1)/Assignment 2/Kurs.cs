using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2Version
{
    class Kurs : IKurs
    {
        public List<Uppgift> kUppgift = new List<Uppgift>();
        public List<Lärare> kLärare = new List<Lärare>();
        public List<Student> kStudent = new List<Student>();

        private string _kursID;
        private string _kursNamn;

        public string KursID
        {
            get { return _kursID; }
            set { _kursID = value; }
        }

        public string KursNamn
        {
            get { return _kursNamn; }
            set { _kursNamn = value; }
        }

        public Kurs()
        {
        }

        public Kurs(string kName, string kursId)
        {
            KursNamn = kName;
            KursID = kursId;
        }

        public void LäggTillStuden(Student s)
        {
            kStudent.Add(s);
        }

        public void TaBortStudent(int index)
        {
            kStudent.RemoveAt(index);
        }

        public void LäggTillLärare(Lärare l)
        {
            kLärare.Add(l);
        }

        public void TaBortLärare(int index)
        {
            kLärare.RemoveAt(index);
        }

        public void LäggTillUppgift(Uppgift u)
        {
            kUppgift.Add(u);
        }

        public void TaBortUppgift(int index)
        {
            kUppgift.RemoveAt(index);
        }
    }
}
