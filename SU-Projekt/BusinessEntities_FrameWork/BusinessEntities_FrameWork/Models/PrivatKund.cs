using BusinessEntities_FrameWork.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Klassen PrivatKund representerar informationen om varje PrivatKund och bygger en model för regler i databas.

namespace BusinessEntities_FrameWork.Models
{
    [Table("PrivatKund")]
    public class PrivatKund : IPrivatKund
    {
        [Key, Column(Order = 0)]
        public int PrivatKundID { get; set; }
        public string PrivatFörnamn { get; set; }
        public string PrivatEfternamn { get; set; }
        public string PrivatGatuadress { get; set; }
        public string PrivatPostnummer { get; set; }
        public string PrivatPostort { get; set; }
        public string PrivatTelefonnummer { get; set; }
        public string PrivatEpostadress { get; set; }
        public double Rabatt { get; set; }

        //// Funktionalitet för att kunna addera, ta bort & uppdatera element i listan 
        public ICollection<Bokning> Bokningar { get; set; }
        public ICollection<Uthyrning> Uthyrningar { get; set; }
        public virtual ICollection<Faktura> Fakturor { get; set; }
        public ICollection<PreBokning> PreBokningar { get; set; }

        public PrivatKund()
        {
            Fakturor = new HashSet<Faktura>();
            Bokningar = new HashSet<Bokning>();
            PreBokningar = new HashSet<PreBokning>();
        }
    }
}
