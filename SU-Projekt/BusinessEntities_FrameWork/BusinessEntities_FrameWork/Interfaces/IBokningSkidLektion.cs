using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Definierar vad det är som skall skickas till facaden

namespace BusinessEntities_FrameWork.Interfaces
{
    public interface IBokningSkidLektion
    {
        public int SkidLektionsID { get; set; }
        public int BokningsID { get; set; }
    }
}
