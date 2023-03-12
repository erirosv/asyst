using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Affärslager.models
{
    public class Bok
    {
        public string ISBN { get; private set; }
        public string Titel { get; private set; }
        List<Bokning> Bokningar { get; set; } = new List<Bokning>();

        internal Bok(string t, string isbn)
        {
            this.ISBN = isbn;
            this.Titel = t;
        }

        internal void LäggTillBokning(Bokning bokning)
        {
            Bokningar.Add(bokning);
        }

        internal bool Tillgänglig()
        {
            foreach (Bokning b in Bokningar)
            {
                if (b.Pågående() || b.Försenad())
                    return false;
            }

            return true;
        }

        internal bool TillgängligaBokningsDatum(DateTime startDatum, DateTime slutDatum)
        {
            foreach (Bokning bokning in Bokningar)
            {
                if (bokning.PågåendeUtlåningar(startDatum, slutDatum))
                    return false;
            }
            return true;
        }

        internal bool KontrolleraBokStatus(DateTime start, DateTime slut)
        {
            foreach (Bokning item in Bokningar)
            {
                if (item.PågåendeUtlåningar(start, slut))
                {
                    return false;
                }
            }

            return true;
        }
    }
}
