using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactorySekil
{
    class Program
    {
        static void Main(string[] args)
        {
            SekilFactory sf = new SekilFactory();
            ISekil sekil = sf.getSekil(SekilFactory.enSekilTur.enCember);
            sekil.Ciz();

            ISekil sekil2 = sf.getSekil(SekilFactory.enSekilTur.enKare);
            sekil2.Ciz();

            Console.ReadLine();

        }
    }
}
