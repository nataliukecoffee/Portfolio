using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VardasPavardeBL;

namespace Klases_nr_1_2019_06_10
{
    public class Program
    {
        static void Main(string[] args)
        {

            VardasPavarde vardasPavarde = new VardasPavarde("Natalija", 
                "Griadovskaja", 
                new DateTime(2000,01,01));
            Console.WriteLine("{0}, {1}, {2}, {3}", vardasPavarde.Vardas, 
                vardasPavarde.Pavarde, 
                vardasPavarde.GimimoMetai.ToLongDateString(),
                vardasPavarde.GetAge()); 
            Console.ReadLine();
        }
        
    }
}
