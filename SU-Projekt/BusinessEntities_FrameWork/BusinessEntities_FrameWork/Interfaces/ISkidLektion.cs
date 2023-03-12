using BusinessEntities_FrameWork.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Definierar vad det är som skall skickas till facaden

namespace BusinessEntities_FrameWork.Interfaces
{
    public interface ISkidLektion
    {
        public int SkidLektionsID { get; set; }
        public string SkidLärare { get; set; }
        public string TypAvLektion { get; set; }
        public string Antal { get; set; }
        public string Deltagarnamn { get; set; }
        public double Pris { get; set; }
        public int Dagar { get; set; }

        public List<PrivatKund> PrivatDeltagare { get; set; }
        public List<FöretagsKund> FöretagDeltagare { get; set; }

        
        public ICollection<BokningSkidLektion> BokningSkidLektioner { get; set; }
        public ICollection<Privatskidlektion> Privatskidlektioner { get; set; }
        public ICollection<Gruppskidlektion> GruppSkidlektioner { get; set; }
        public int Tid { get; set; }
        //public Privatskidlektion Privatskidlektion { get; set; }
        //public Gruppskidlektion Gruppskidlektion { get; set; }
    }
}
