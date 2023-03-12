using BusinessEntities_FrameWork.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Klassen anställd representerar informationen om varje anställd och bygger en model för regler i databas. 
// 

namespace BusinessEntities_FrameWork.Models
{
    [Table("Anställd")]
    public class Anställd : IAnställd
    {
        [Key, Column(Order = 0)] //Försäkrar om att ID nummer sökes i rätt kolumn på databas 
        public int AnställningsID { get; set; }

        [Required]          
        [StringLength(16)] //Försäkrar om att namnet inte blir för långt 
        public string AnvändarNamn { get; set; }

        [Required]
        [StringLength(20)]//Försäkrar om att lösenordet inte blir för långt 
        public string Lösenord { get; set; }

        [Required]
        public string AnställdFörnamn { get; set; }

        public string AnställdEfternamn { get; set; }
        public string AnställningsTyp { get; set; }
        public string Behörighet { get; set; }

        public virtual ICollection<Bokning> Bokningar { get; set; } // Funktionalitet för att kunna addera, ta bort & uppdatera element i listan för bokningar 

        public virtual ICollection<Uthyrning> Uthyrningar { get; set; } // Funktionalitet för att kunna addera, ta bort & uppdatera element i listan för uthyrningar 

        // Constructor
        public Anställd()
        {

        }
      
    }
}
