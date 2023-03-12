using Affärslager.models;
using Affärslager.Datastore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Affärslager.controller
{
    public class Bibliotek
    {
        internal Anställd Anställd { get; set; }
        internal DataStore DataStore { get; set; }

        public Bibliotek()
        {
            DataStore = new DataStore(this);
        }

        public bool LoggIn(int anställningsnummer, string lösenord)
        {
            Anställd anställd = null;

            foreach (Anställd item in DataStore.Anställda)
            {
                if (item.AnställningsNr == anställningsnummer)
                {
                    anställd = item;
                }
            }

            if (anställd == null)
            {
                return false;
            }
            
            if (anställd.VeryfyPassword(lösenord))
            {
                Anställd = anställd;
                return true;
            }

            return false;
        }

        public int BokaBok(List<Bok> bokningBöcker, int medlemsnummer, DateTime start, DateTime slut)
        {
            foreach (Bok item in bokningBöcker)
            {
                if (!item.TillgängligaBokningsDatum(start, slut))
                {
                    return -1;
                }
            }

            Bokning b = new Bokning(bokningBöcker, medlemsnummer, start, slut, Anställd.AnställningsNr);
            DataStore.Bokningar.Add(b);
            return b.BokningsNummer;
        }

        public void UtlämningAvBok(Bokning b)
        {
            b.UtlämningAvBok();
        }

        public Faktura ÅterlämningAvBok(int bokningsnummer)
        {
            Bokning b = DataStore.HittaSpecifikBokning(bokningsnummer);

            if (b.Uthämtad && !b.Återlämnats)
            {
                b.ÅterlämningAvBöcker();
            }


            DataStore.Bokningar.Remove(b);

            return b.Faktura;
        }

        public List<Bokning> AllaBokningar()
        {
            return DataStore.Bokningar;
        }

        public Bokning SpecifikBokning(int bokninsnummer)
        {
            return DataStore.HittaSpecifikBokning(bokninsnummer);
        }

        public List<Bok> TillgängligaBöcker()
        {
            List<Bok> temp = new List<Bok>();

            foreach (Bok item in DataStore.Böcker)
            {
                if (item.Tillgänglig())
                {
                    temp.Add(item);
                }
            }

            return temp;
        }

        public void TaBortBokning(int bokningsnummer)
        {
            Bokning b = DataStore.HittaSpecifikBokning(bokningsnummer);

            if (!b.Uthämtad && !b.Återlämnats)
            {
                b.ÅterlämningAvBöcker();
            }

            DataStore.Bokningar.Remove(b);
        }
    }
}
