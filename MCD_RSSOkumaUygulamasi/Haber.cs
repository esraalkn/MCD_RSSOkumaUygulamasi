﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MCD_RSSOkumaUygulamasi
{
    class Haber
    {
        public string Baslik { get; set; }

        public string Link { get; set; }
        public string Aciklama { get; set; }

        public override string ToString()
        {
            return Baslik;
        }

    }
}
