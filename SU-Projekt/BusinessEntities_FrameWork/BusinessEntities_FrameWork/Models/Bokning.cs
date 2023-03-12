using BusinessEntities_FrameWork.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Klassen bokning representerar informationen om varje bokning och bygger en model för regler i databas.

namespace BusinessEntities_FrameWork.Models
{
    [Table("Bokning")]
    public class Bokning : IBokning
    {
        [Key, Column(Order = 0)]
        public int BokningsID { get; set; }
        [Required]
        public DateTime InCheckningsDatum { get; set; }
        [Required]
        public DateTime UtCheckningsDatum { get; set; }
        public string BokningsTyp { get; set; }
        public double BokningsPris { get; set; }
        public double Moms { get; set; }
        public double Bruttopris { get; set; }
        public double Nettopris { get; set; }
        public bool Status { get; set; }
        public double Rabatt { get; set; }
        public bool Avbeställningsskydd { get; set; }

        // Constructor
        public Bokning()
        {
            Fakturor = new HashSet<Faktura>();
            PreBokningar = new HashSet<PreBokning>();
            Konferenser = new HashSet<Konferens>();
            BokaSkidLektioner = new HashSet<BokningSkidLektion>();
            UtrustningsLista = new HashSet<Utrustning>();
            LogiTillBokning = new HashSet<Logi>();
        }

        // External properies
        public Anställd Anställd { get; set; }
        public PrivatKund PrivatKund { get; set; }
        public FöretagsKund FöretagsKund { get; set; }
        public TempKund TempKund { get; set; }

        // Funktionalitet för att kunna addera, ta bort & uppdatera element i listan  
        // Räknar även värdet av element i listan och behöver inte itereras genom alla element för att få fram de totala elementen 
        public virtual ICollection<Faktura> Fakturor { get; set; }
        public virtual ICollection<PreBokning> PreBokningar { get; set; }
        public virtual ICollection<Konferens> Konferenser { get; set; }
        public virtual ICollection<BokningSkidLektion> BokaSkidLektioner { get; set; }
        public virtual ICollection<Utrustning> UtrustningsLista { get; set; }
        public virtual ICollection<Logi> LogiTillBokning{ get; set; }
    }
}
