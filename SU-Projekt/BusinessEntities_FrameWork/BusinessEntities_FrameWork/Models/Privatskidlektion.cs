using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Klassen Privatskidlektion representerar informationen om varje privata skidlektion och bygger en model för regler i databas.

namespace BusinessEntities_FrameWork.Models
{
    public class Privatskidlektion : IPrivatskidlektion
    {
        [Key, Column(Order = 0)]
        public int PrivatskidlektionsID { get; set; }
        public int Antaldeltagare { get; set; }
        public string Lärare { get; set; }

        // --
        public int Tid { get; set; }
        public SkidLektion SkidLektion { get; set; }
        public ICollection<Deltagare> PrivatDeltagare { get; set; } // // Funktionalitet för att kunna addera, ta bort & uppdatera element i listan för privatdeltagare 

        public Privatskidlektion()
        {
            PrivatDeltagare = new HashSet<Deltagare>();
        }
    }
}
