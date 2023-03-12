using BusinessEntities_FrameWork.Models;
using BusinessLayer_FrameWork;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * Detta är en hjälpklass som concatinerar Efternamn och Förnamn 
 * för båden privatkund samt, Företagskund.
 */

namespace GUI_FrameWork
{
    internal class DisplayKund
    {
        //public FacadeBusiness FacadeBusiness { get; set; }
        public PrivatKund PrivatKund { get; set; }
        public FöretagsKund FöretagsKund { get; set; }
        public string Namn 
        {
            get
            {
                if (PrivatKund != null)
                {
                    return PrivatKund.PrivatEfternamn + " , " + PrivatKund.PrivatFörnamn;
                }
                if (FöretagsKund != null)
                {
                    return FöretagsKund.Företagsnamn;
                }
                return null;
            }              
        }

        public object Connection { get; internal set; }
        public object Orders { get; internal set; }

        public DisplayKund(PrivatKund pk)
        {
            PrivatKund = pk;
        }

        public DisplayKund(FöretagsKund fk)
        {
            FöretagsKund = fk;
        }
    }
}
