using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Struktura_Nr._1
{
    class Program
    {
        struct Mokinys
        {
            public string Vardas;
            public string Pavarde;
            public DateTime Kurso_pradzia;
            public DateTime Kurso_pabaiga;
            
        };
        static void Main(string[] args)
        {
            Mokinys mok;
            mok.Vardas = "Tomas";
            mok.Pavarde = "Petrauskas";
            mok.Kurso_pradzia = new DateTime(2019, 05, 20);
            mok.Kurso_pabaiga = new DateTime(2019, 07, 04);

            Console.WriteLine(mok.Vardas);
            Console.WriteLine(mok.Pavarde);
            Console.WriteLine(mok.Kurso_pradzia);
            Console.WriteLine(mok.Kurso_pabaiga);
            Console.ReadLine();

        }
    }
}
