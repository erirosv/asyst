using BusinessEntities_FrameWork.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Klassen Logi representerar informationen om varje logi och bygger en model för regler i databas.

namespace BusinessEntities_FrameWork.Models
{
    [Table("Logi")]
    public class Logi : ILogi
    {
        [Key, Column(Order = 0)]
        public int LogiID { get; set; }
        [Required]
        public string LogiTyp { get; set; }
        [Required]
        public int Dagar { get; set; }
        [Required]
        public int Vecka { get; set; }
        public bool Tillgänglighet { get; set; }
        public double LogiPris { get; set; }

        public Logi()
        {

        }
        public Bokning Bokning { get; set; }
        public PreBokning PreBokning { get; set; }
    }
}
