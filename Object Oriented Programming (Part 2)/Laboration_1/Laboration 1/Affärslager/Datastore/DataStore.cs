using Affärslager.controller;
using Affärslager.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Affärslager.Datastore
{
    public class DataStore
    {
        internal Bibliotek Bibliotek { get; set; }

        internal List<Anställd> Anställda { get; set; } = new List<Anställd>();
        public List<Bok> Böcker { get; set; } = new List<Bok>();
        public List<Bokning> Bokningar { get; set; } = new List<Bokning>();
        public List<Faktura> Fakturor { get; set; } = new List<Faktura>();
        internal List<Medlem> Medlemmar { get; set; } = new List<Medlem>();

        internal DataStore(Bibliotek b)
        {
            Bibliotek = b;
            LaddaInAnställda();
            LaddaInBöcker();
        }

        internal void LaddaInBöcker()
        {
            Bok b1 = new Bok("En vacker Dagbok", "1");
            Böcker.Add(b1);

            Bok b2 = new Bok("Anne Franks Dagbok", "2");
            Böcker.Add(b2);

            Bok b3 = new Bok("Allt I Köket Kokbok", "3");
            Böcker.Add(b3);

            Bok b4 = new Bok("Att Bygga Ett Hus", "4");
            Böcker.Add(b4);

            Bok b5 = new Bok("Hjälp jag är en fisk", "5");
            Böcker.Add(b5);

            Bok b6 = new Bok("Vårt matematiska universum", "6");
            Böcker.Add(b6);

            Bok b7 = new Bok("Shadowhunter Vol.1", "7");
            Böcker.Add(b7);

            Bok b8 = new Bok("Avatar: The Last Airbender Vol.1", "8");
            Böcker.Add(b8);

            Bok b9 = new Bok("Avatar: Legend Of Korra", "9");
            Böcker.Add(b9);
        }

        internal void LaddaInAnställda()
        {
            Anställd a1 = new Anställd(1, "Expedit", "123");
            Anställda.Add(a1);

            Anställd a2 = new Anställd(2, "Expedit", "123");
            Anställda.Add(a2);

            Anställd a3 = new Anställd(3, "Expedit", "123");
            Anställda.Add(a3);
        }

        internal Bokning HittaSpecifikBokning(int bokningsNummer)
        {
            foreach (Bokning item in Bokningar)
            {
                if (item.BokningsNummer == bokningsNummer)
                {
                    return item;
                }
            }
            return null;
        }

        internal List<Bokning> HittaAllaBokningarFörMedlem(int medlemsnummer)
        {
            List<Bokning> mBokningar = new List<Bokning>();

            foreach (Bokning item in Bokningar)
            {
                if (item.MedlemsNummer == medlemsnummer)
                {
                    mBokningar.Add(item);
                }
            }

            return mBokningar;
        }
    }
}
