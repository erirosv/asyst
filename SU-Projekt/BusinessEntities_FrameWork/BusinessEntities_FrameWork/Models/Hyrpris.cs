using BusinessEntities_FrameWork.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Klassen hyrpris representerar informationen om varje hyrpris och bygger en model för regler i databas.

namespace BusinessEntities_FrameWork.Models
{
    [Table("Hyrpris")]
    public class Hyrpris : IHyrpris
    {

        [Key, Column(Order = 0)]
        public int HyrPirsID { get; set; }

        public string UtrustningSort { get; set; }

        public string UtrustningsTyp { get; set; }

        [Required]
        public int AntalDagar { get; set; }
        public double Pris { get; set; }

        // Constructor
        public Hyrpris()
        {
            Utrustning = new HashSet<Utrustning>();
        }
        public ICollection<Utrustning> Utrustning { get; set; } // Funktionalitet för att kunna addera, ta bort & uppdatera element i listan för utrustning  
    }
}
