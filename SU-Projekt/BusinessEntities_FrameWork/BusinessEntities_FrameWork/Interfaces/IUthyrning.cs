﻿using BusinessEntities_FrameWork.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Definierar vad det är som skall skickas till facaden

namespace BusinessEntities_FrameWork.Interfaces
{
    public interface IUthyrning
    {
        public int UthyrningsID { get; set; }
        public int AntalDagar { get; set; }
        public double UthyrningsPris { get; set; }
        public bool Status { get; set; }
   
    }
}
