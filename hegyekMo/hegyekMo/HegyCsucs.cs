using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hegyekMo
{
    internal class HegyCsucs
    {
        public string hegycsucs { get; set; }
        public string hegyegE { get; set; }
        public double magassag { get; set; }

        public HegyCsucs(string hegycsucs, string hegysegE, int magassag)
        {
            this.hegycsucs = hegycsucs;
            this.hegyegE = hegyegE;
            this.magassag = magassag;
        }
    }
    
}
