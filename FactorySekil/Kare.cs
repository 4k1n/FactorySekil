﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactorySekil
{
    public class Kare : ISekil
    {
        public void Ciz()
        {
            Console.WriteLine("Kare çizildi");
        }
    }
}
