using System;
using System.Collections.Generic;
using System.Linq;

namespace Week2Deel1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Moeten er records worden aangemaakt?");
            string keuze = Console.ReadLine();
            HuisenContext hc = new HuisenContext();

            if (keuze.ToLower().Equals("ja"))
            {
                Huis h1 = new Huis() { AantalKamers = 4, Bouwjaar = 1982, Plaats = "Den Haag" };
                Huis h2 = new Huis() { AantalKamers = 12, Bouwjaar = 1993, Plaats = "Rotterdam" };
                Huis h3 = new Huis() { AantalKamers = 2, Bouwjaar = 1912, Plaats = "Utrecht" };

                
                hc.Add(h1);
                hc.Add(h2);
                hc.Add(h3);

                hc.SaveChanges();
            }

            Console.WriteLine("All Records");
            foreach(Huis h in hc.Huisen)
            {
                Console.WriteLine("ID: {0} - Bouwjaar: {1}", h.HuisId, h.Bouwjaar);
            }

            Console.WriteLine("Ordered by bouwjaar");
            List<Huis> Huisen = hc.Huisen.OrderBy(h => h.Bouwjaar).ToList();
            foreach (Huis h in Huisen)
            {
                Console.WriteLine("ID: {0} - Bouwjaar: {1}", h.HuisId, h.Bouwjaar);
            }

            Console.WriteLine("Selected alles na bouwjaar 1980");
            Huisen = hc.Huisen.Where(h => h.Bouwjaar > 1980).ToList();
            foreach (Huis h in Huisen)
            {
                Console.WriteLine("ID: {0} - Bouwjaar: {1}", h.HuisId, h.Bouwjaar);
            }

            Console.ReadKey();
        }

        
    }
}
