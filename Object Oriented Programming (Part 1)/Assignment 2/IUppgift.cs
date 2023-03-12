namespace Lab2Version
{
    interface IUppgift
    {
        string KursID { get; set; }
        string Sid { get; set; }
        string UpgBetyg { get; set; }
        string UpgName { get; set; }

        void LäggTillUppgift(Uppgift u);
    }
}