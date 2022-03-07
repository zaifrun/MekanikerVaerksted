//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;

using System;

namespace MekanikerVærksted
{
    class MekanikerVærkstedsProgram
    {
       
       
        static void Main(string[] args)
        {
            
            Mekaniker Ole = new Mekaniker();
            Ole.Navn = "Ole Hansen";
            Ole.Adresse = "Nyvej 12";
            Ole.Svendeår = 2004;
            Ole.Timeløn = 100.00;

            Værkfører Peter = new Værkfører();
            Peter.Navn = "Peter Olsen";
            Peter.Adresse = "Søvej 1";
            Peter.Svendeår = 1999;
            Peter.Udnævnelsesår = 2001;
            Peter.Timeløn = 150.00;
            Peter.Ugetillæg = 20.00;

            Synsmand Sven = new Synsmand();
            Sven.Navn = "Sven Sørensen";
            Sven.Adresse = "Bakkedraget 2";
            Sven.Svendeår = 1980;
            Sven.AntalSynPrUge = 20;

            Console.WriteLine(Ole);
            Console.WriteLine("Løn Ole: " + Ole.BeregnUgeLøn());
            Console.WriteLine(Peter);
            Console.WriteLine("Løn Peter: " + Peter.BeregnUgeLøn());
            Console.WriteLine(Sven);
            Console.WriteLine("Løn Sven: " + Sven.BeregnUgeLøn());

        
            Console.ReadLine();
        }
    }
}
