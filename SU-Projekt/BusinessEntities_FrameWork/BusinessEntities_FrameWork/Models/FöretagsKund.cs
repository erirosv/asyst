using BusinessEntities_FrameWork.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

///Klassen företagsKund representerar informationen om varje företagsKund och bygger en model för regler i databas.

namespace BusinessEntities_FrameWork.Models
{
    [Table("FöretagsKund")]
    public class FöretagsKund : IFöretagsKund
    {
        [Key, Column(Order = 0)]
        public int FöretagKundID { get; set; }
        [Required]
        public string Företagsnamn { get; set; }
        [Required]
        public string OrgNummer { get; set; }
        [Required]
        public double FöretagRabatt { get; set; }
        [Required]
        public string RefPerson { get; set; }
        [Required]
        public string FöretagTelefonNummer { get; set; }
        [Required]
        public string FöretagEpostadress { get; set; }
        [Required]
        public string Gatuadress { get; set; }
        [Required]
        public string FöretagPostnummer { get; set; }
        [Required]
        public string FöretagPostort { get; set; }
        public string Faktureringsadress { get; set; }
        public string FöretagFaktureringPostnummer { get; set; }
        public string FöretagFaktureringPostort { get; set; }
        public double Kreditgräns { get; set; }

        // Funktionalitet för att kunna addera, ta bort & uppdatera element i listan  
        // Räknar även värdet av element i listan och behöver inte itereras genom alla element för att få fram de totala elementen 
        public ICollection<Bokning> Bokningar { get; set; }
        public ICollection<Uthyrning> Uthyrningar { get; set; }
        public ICollection<Faktura> Fakturor { get; set; }
        public ICollection<PreBokning> PreBokningar { get; set; }

        // HashSet används här för att förhindra att duplicera element i samlingen
        public FöretagsKund()
        {
            Fakturor = new HashSet<Faktura>();
            Bokningar = new HashSet<Bokning>();
            PreBokningar = new HashSet<PreBokning>();
        }
    }
}
