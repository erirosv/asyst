﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessEntities_FrameWork.Models;

// Bygger specifikt gränssnitt och implementerar datan från respektive modul. 
// Användaren kan göra specfika val utan att påverka alla subklasser.

namespace BusinessLayer_FrameWork.Interfaces
{
    public interface IFacadeButiksregister
    {
        public List<Utrustning> GetAllProdukter();
    }
}
