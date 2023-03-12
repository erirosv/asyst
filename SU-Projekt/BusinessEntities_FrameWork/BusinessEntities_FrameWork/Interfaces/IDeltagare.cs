using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Definierar vad det är som skall skickas till facaden

namespace BusinessEntities_FrameWork.Interfaces
{
    public interface IDeltagare
    {
        public int DeltagarID { get; set; }
        public string DeltagarFörnamn { get; set; }
        public string DeltagarEfternamn { get; set; }
    }
}
