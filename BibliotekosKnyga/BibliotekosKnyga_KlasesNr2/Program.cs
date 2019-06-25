using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BibliotekosKnygaStruct;

namespace BibliotekosKnyga_KlasesNr2
{
    class Program
    {
        static void Main(string[] args)
        {
            BibliotekosKnyga knyga1 = new BibliotekosKnyga(101, "Gera Knyga", 14, "Natalija", new DateTime(2019,06,01));
            Console.WriteLine("{0}. {1}, {2}, {3}, {4}",  knyga1.Id, 
                knyga1.Pavadinimas, knyga1.PerKiekDienuGrazinti, 
                knyga1.SkaitytojoVardas, knyga1.PerKiekDienuGrazinti);
  
            Console.ReadLine();
        }

        
    }
}
