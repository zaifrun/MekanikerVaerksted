//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;

namespace MekanikerVærksted
{
    public class Mekaniker : Person
    {
        private int svendeår = 0;
        private double timeløn = 0.0;

        public Mekaniker() { }

        public override string ToString()
        {
            return base.ToString()+$", svendeår: {Svendeår}, timeløn: {Timeløn}";
        }


        public Mekaniker(string navn, string adresse) : base(navn, adresse)
        {

        }

        public Mekaniker(string navn, string adresse, int svendeår, double timeløn)
            : base(navn,adresse)
        {
            Svendeår = svendeår;
            Timeløn = timeløn;
        }
        
        public override double BeregnUgeLøn()
        {
            return TimerPrUge * timeløn;
        }

        public int Svendeår
        {
            get { return svendeår; }
            set { svendeår = value; }
        }

        public double Timeløn
        {
            get { return timeløn; }
            set { timeløn = value; }
        }

    }

}
