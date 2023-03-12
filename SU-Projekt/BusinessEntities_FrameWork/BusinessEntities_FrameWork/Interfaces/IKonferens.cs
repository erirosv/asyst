using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Definierar vad det är som skall skickas till facaden

namespace BusinessEntities_FrameWork.Interfaces
{
    public interface IKonferens
    {
        public int KonferensID { get; set; }
        public string KonferensTyp { get; set; }
        public bool Tillgänglig { get; set; }
        public DateTime Start { get; set; }
        public DateTime Slut { get; set; }
    }
}
