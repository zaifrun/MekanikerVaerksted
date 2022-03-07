//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;

namespace MekanikerVærksted
{
    public class Værkfører : Mekaniker
    {
        private int udnævnelsesår = 0;
        private double ugetillæg = 0.0;

        public override string ToString()
        {
            return base.ToString()+$", Udnævnelsesår: {Udnævnelsesår}, ugetillæg: {Ugetillæg}";
        }

        public int Udnævnelsesår
        {
            get { return udnævnelsesår; }
            set { udnævnelsesår = value; }
        }

        public double Ugetillæg
        {
            get { return ugetillæg; }
            set { ugetillæg = value; }
        }

        public override double BeregnUgeLøn()
        {
            return base.BeregnUgeLøn() + Ugetillæg;
        }

    }

}
