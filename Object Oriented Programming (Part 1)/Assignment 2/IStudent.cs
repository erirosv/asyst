namespace Lab2Version
{
    interface IStudent
    {
        string KursName { get; set; }
        string StudentId { get; set; }

        void LäggTillKurs(Kurs k);
        void LäggTillStudent(string n, string p, string id);
        void LäggTillUppgift(Uppgift u);
        void TaBortKurs(int index);
        void TaBortUppgift(int index);
    }
}