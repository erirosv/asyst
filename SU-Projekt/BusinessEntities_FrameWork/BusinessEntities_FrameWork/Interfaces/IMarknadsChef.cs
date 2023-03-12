using BusinessEntities_FrameWork.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Definierar vad det är som skall skickas till facaden

namespace BusinessEntities_FrameWork.Interfaces
{
    interface IMarknadsChef : IAnställd
    {
        public ICollection<Bokning> PreBokning { get; set; }
    }
}
