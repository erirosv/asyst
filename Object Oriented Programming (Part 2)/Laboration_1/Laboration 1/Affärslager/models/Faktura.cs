using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Affärslager.models
{
    public class Faktura
    {
        Bokning Bokning { get; set; }
        int Totalpris { get; set; } = 0;
        DateTime Uthämtning { get; set; }
        DateTime Återlämning { get; set; }

        internal Faktura(Bokning bokning, DateTime uthämtning)
        {
            Bokning = bokning;
            Uthämtning = uthämtning;
            Återlämning = DateTime.Today;

            int dagarförsenad = (Återlämning - Bokning.SlutDatum).Days;

            if (dagarförsenad > 0)
                Totalpris = Bokning.Böcker.Count * dagarförsenad * 10;
        }

        public override string ToString()
        {
            return String.Format($"Faktura: { Bokning.BokningsNummer} \n" +
                $"Totalpris: { Totalpris} kr\n" +
                $"Uthämtad { Uthämtning}\n" +
                $"Återlämnad: { Återlämning}");
        }
    }
}
