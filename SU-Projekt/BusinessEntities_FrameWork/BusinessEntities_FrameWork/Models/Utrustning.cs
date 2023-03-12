using BusinessEntities_FrameWork.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Klassen Utrustning representerar informationen om varje utrustning och bygger en model för regler i databas.

namespace BusinessEntities_FrameWork.Models
{
    [Table("Utrustning")]
    public class Utrustning : IUtrustning
    {
        [Key, Column(Order = 0)]
        public int ArtikelID { get; set; }
        public string UtrustningSort { get; set; } // alpint
        public string UtrustningsTyp { get; set; } // pjäxor

        public bool PaketStatus { get; set; } // Visar true om den ingår i ett paket;
       public bool Tillgänglig { get; set; }

        // Constructor
        public Utrustning()
        {

        }

        //public ICollection<Uthyrning> Uthyrning { get; set; }
        public Uthyrning Uthyrning { get; set; }
        public ICollection<Hyrpris> Hyrpris { get; set; }
    }
}
