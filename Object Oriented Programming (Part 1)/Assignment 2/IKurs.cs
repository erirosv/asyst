namespace Lab2Version
{
    interface IKurs
    {
        string KursID { get; set; }
        string KursNamn { get; set; }

        void LäggTillLärare(Lärare l);
        void LäggTillStuden(Student s);
        void LäggTillUppgift(Uppgift u);
        void TaBortLärare(int index);
        void TaBortStudent(int index);
        void TaBortUppgift(int index);
    }
}