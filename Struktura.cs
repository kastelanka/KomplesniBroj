﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KomplesniBroj
{
    struct KompleksniBrojStruktura
    {
        public KompleksniBrojStruktura(double realni, double imaginarni)
        {
            RealniDio = realni;
            ImaginarniDio = imaginarni;
        }

        public double RealniDio;
        public double ImaginarniDio;
        public override string ToString()
        {
            //dolar - sve u vitičastima je varaijabla pa se one zamijene podatkom.
            return $"({RealniDio}, {ImaginarniDio})";
        }
    }
}
