// ReSharper disable RedundantUsingDirective
//using System;
// ReSharper restore RedundantUsingDirective
// ReSharper disable RedundantUsingDirective
//using System.Collections.Generic;
// ReSharper restore RedundantUsingDirective
//using System.Linq;
//using System.Text;

namespace MekanikerVærksted
{
    public class Person
    {
        private string navn = "";
        private string adresse = "";
        private const int timerPrUge = 37;

        public Person() { }



        public override string ToString()
        {
            return $"navn: {Navn}, adresse: {Adresse} ";
        }

        public Person(string navn, string adresse)
        {
            Navn = navn;
            Adresse = adresse;
        }

        public virtual double BeregnUgeLøn()
        {
            return 0.0;
        }

        public string Navn {
            get { return navn; }
            set { navn = value; }
        }

        public string Adresse
        {
            get { return adresse; }
            set { adresse = value; }
        }

        public int TimerPrUge 
        {
            get { return timerPrUge; }
        }
    }

}
