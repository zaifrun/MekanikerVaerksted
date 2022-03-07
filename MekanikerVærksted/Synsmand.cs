//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;

namespace MekanikerVærksted
{
    public class Synsmand : Mekaniker
    {
        private int antalSynPrUge = 0;
        private const double lønPrSyn = 290;

        public override string ToString()
        {
            return base.ToString()+$", syn per uge: {AntalSynPrUge} "+
                $", Løn per syn: {lønPrSyn}";
        }

        public Synsmand()
        {

        }

        public int AntalSynPrUge
        {
            get { return antalSynPrUge; }
            set { antalSynPrUge = value; }
        }

        public override double BeregnUgeLøn()
        {
            return antalSynPrUge * lønPrSyn;
        }

    }
}
