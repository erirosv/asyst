using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Klassen gruppskidlektion representerar informationen om varje gruppskidlektion och bygger en model för regler i databas.

namespace BusinessEntities_FrameWork.Models
{
    [Table("Gruppskidlektion")]
    public class Gruppskidlektion : IGruppskidlektion
    {
        [Key, Column(Order = 0)]
        public int GruppskidlektionsID { get; set; }

        [Required]
        public string Färg { get; set; }

        [Required]
        public int Antaldeltagare { get; set; }

        public string Lärare { get; set; }

        public bool Status { get; set; }

        public List<PrivatKund> PrivatDeltagare { get; set; }
        public List<FöretagsKund> FöretagDeltagare { get; set; }
        // Constructor
        public Gruppskidlektion()
        {
            GruppDeltagare = new HashSet<Deltagare>();
        }

        
        public SkidLektion SkidLektion { get; set; }
        public ICollection<Deltagare> GruppDeltagare { get; set; }
        public int AntalDagar { get; set; }
        public string LektionsTyp { get; set; }
        public object DeltagarNamn { get; set; }
    }
}
