using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Affärslager.models
{
    public class Anställd
    {
        internal int AnställningsNr { get; private set; }

        string Namn { get; set; }
        string Email { get; set; }
        string Lösenord { get; set; }
        string Roll { get; set; }

        internal Anställd(int anställningsNr, string roll, string lösenord)
        {
            AnställningsNr = anställningsNr;
            Lösenord = lösenord;
            Roll = roll;
        }

        internal bool VeryfyPassword(string password)
        {
            if (password == Lösenord)
            {
                return true;
            }

            return false;
            
        }

    }
}
