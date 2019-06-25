using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        struct Zmogus
        {
            public string Vardas;
            public string Pavarde;
        };
        static void Main(string[] args)
        {
            Zmogus zmogus1;
            zmogus1.Vardas = "Natalija";
            zmogus1.Pavarde = "Griadovskaja";

            Console.WriteLine(zmogus1.Vardas + " " + zmogus1.Pavarde);
            Console.ReadLine();
        }
    }
}
