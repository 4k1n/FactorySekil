using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactorySekil
{
    public class SekilFactory
    {
        public enum enSekilTur
        {
            enKare,
            enCember,
            enDikdortgen
                
        }
        public ISekil getSekil(enSekilTur sekilTur)
        {
            switch (sekilTur)
            {
                case enSekilTur.enKare:
                    return new Kare();
                case enSekilTur.enCember:
                    return new Cember();
                case enSekilTur.enDikdortgen:
                    return new Dikdortgen();
                default:
                    return null;
            }
        }
    }
}
