using BusinessEntities_FrameWork.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Klassen faktura representerar informationen om varje faktura och bygger en model för regler i databas.

namespace BusinessEntities_FrameWork.Models
{
    [Table("Faktura")]
    public class Faktura : IFaktura
    {
        [Key, Column(Order = 0)]
        public int FakturaID { get; set; }        
        [Required]
        public double Pris { get; set; }
        public DateTime FaktureringsDatum { get; set; } 
        public DateTime FörfalloDatum { get; set; }
        public string Typ { get; set; }
        public bool Status { get; set; }
        
        public PrivatKund Privat { get; set; }
        public FöretagsKund Företag { get; set; }

        public Faktura()
        {
            Bokningar = new HashSet<Bokning>(); // En oordnad samling unika element 
        }

        
        public Uthyrning Uthyrning { get; set; }
        public Bokning Bokning { get; set; }
        public ICollection<Bokning> Bokningar { get; set; }
    }
}
