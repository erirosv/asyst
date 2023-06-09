﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Definierar vad det är som skall skickas till facaden

namespace BusinessEntities_FrameWork.Interfaces
{
    public interface IHyrpris
    {
        public int HyrPirsID { get; set; }
        public string UtrustningSort { get; set; }
        public string UtrustningsTyp { get; set; }
        public int AntalDagar { get; set; }
        public double Pris { get; set; }
    }
}
