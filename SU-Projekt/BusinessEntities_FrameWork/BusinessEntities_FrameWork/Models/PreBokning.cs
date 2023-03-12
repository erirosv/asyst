using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessEntities_FrameWork.Interfaces;

//Klassen PreBokning representerar informationen om varje PreBokning och bygger en model för regler i databas.

namespace BusinessEntities_FrameWork.Models
{
    public class PreBokning : IBokning
    {
        [Key, Column(Order = 0)]
        public int BokningsID { get; set; }
        [Required]
        public DateTime InCheckningsDatum { get; set; }
        [Required]
        public DateTime UtCheckningsDatum { get; set; }
        [Required]
        public string BokningsTyp { get; set; }
        public double BokningsPris { get; set; }
        public double Moms { get; set; }
        public double Bruttopris { get; set; }
        public double Nettopris { get; set; }
        public bool Status { get; set; }
        public bool Avbeställningsskydd { get; set; }
        public double Rabatt { get; set; }
        public PreBokning()
        {
            LogiTillBokning = new HashSet<Logi>();
            KonferensTillBokning = new HashSet<Konferens>();
        }
        // --
        public Bokning Bokning { get; set; }
        public PrivatKund PrivatKund { get; set; }
        public FöretagsKund FöretagsKund { get; set; }
        public virtual ICollection<Logi> LogiTillBokning { get; set; } // Funktionalitet för att kunna addera, ta bort & uppdatera element i listan för LogiTillBokning 
        public virtual ICollection<Konferens> KonferensTillBokning { get; set; }
    }
}
