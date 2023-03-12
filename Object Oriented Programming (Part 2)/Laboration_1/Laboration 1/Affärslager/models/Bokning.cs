using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Affärslager.models
{
    public class Bokning
    {
        static int bokningsnummer = 0;

        internal int AnställningsNr { get; set; }
        public List<Bok> Böcker { get; private set; } = new List<Bok>();
        public int BokningsNummer { get; private set; }
        internal int MedlemsNummer { get; private set; }
        public DateTime StartDatum { get; private set; }
        public DateTime SlutDatum { get; private set; }
        public Faktura Faktura { get; private set; }
        DateTime Uthämtning { get; set; } = DateTime.MinValue;
        public bool Uthämtad { get { return Uthämtning != DateTime.MinValue; } }

        public bool Återlämnats
        {
            get { return Faktura != null; }
        }

        internal Bokning(List<Bok> böcker, int medlemsNr, DateTime startDatum, DateTime slutDatum, int anställningsNr)
        {
            foreach (Bok b in böcker)
                LäggTillBok(b);

            MedlemsNummer = medlemsNr;
            StartDatum = startDatum;
            SlutDatum = slutDatum;
            AnställningsNr = anställningsNr;

            BokningsNummer = bokningsnummer;
            bokningsnummer++;
        }

        internal void LäggTillBok(Bok bok)
        {
            Böcker.Add(bok);
            bok.LäggTillBokning(this);
        }

        internal Faktura ÅterlämningAvBöcker()
        {
            
            Faktura = new Faktura(this, Uthämtning);
            return Faktura;
        }
 
        internal bool PågåendeUtlåningar(DateTime startDatum, DateTime slutDatum)
        {
            if (StartDatum.Date <= startDatum.Date && SlutDatum.Date >= slutDatum.Date && (!Återlämnats))
            {
                return true;
            }
                
            return false;
        }

        internal bool Pågående()
        {
            return PågåendeUtlåningar(DateTime.Now, DateTime.Now);
        }

        internal bool Försenad()
        {
            return Uthämtad && !Återlämnats;
        }

        internal void UtlämningAvBok()
        {
            if (Pågående() && !Uthämtad)
                Uthämtning = DateTime.Now;
        }

        internal void BöckerTillLager()
        {

        }

    }
}
