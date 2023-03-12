using BusinessEntities_FrameWork.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Klassen SkidLektion representerar informationen om varje Skidlektion och bygger en model för regler i databas.

namespace BusinessEntities_FrameWork.Models
{
    [Table("SkidLektion")]
    public class SkidLektion : ISkidLektion
    {
        [Key, Column(Order = 0)]
        public int SkidLektionsID { get; set; }
        public string SkidLärare { get; set; }
        public string TypAvLektion { get; set; }
        public string Antal { get; set; }
        public string Deltagarnamn { get; set; }
        public double Pris { get; set; }
        public int Dagar { get; set; }

        // constructor
        public List<PrivatKund> PrivatDeltagare { get; set; }
        public List<FöretagsKund> FöretagDeltagare { get; set; }

        public SkidLektion()
        {
            PrivatDeltagare = new List<PrivatKund>();
            FöretagDeltagare = new List<FöretagsKund>();
            Privatskidlektioner = new HashSet<Privatskidlektion>();
            GruppSkidlektioner = new HashSet<Gruppskidlektion>();
        }

        // --
        public ICollection<BokningSkidLektion> BokningSkidLektioner { get; set; }
        public ICollection<Privatskidlektion> Privatskidlektioner { get; set; }
        public ICollection<Gruppskidlektion> GruppSkidlektioner { get; set; }
        public int Tid { get; set; }
    }
}
