using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp71
{
    class Program
    {
        static void Main(string[] args)
        {
           
            for (int i = 1; i <= 4; i++)
            {
                for (int j = 1; j <= 4 - i; j++)
                {
                }
                for (int k = 1; k <= i; k++)
                {
                    Console.Write("*");
                }
                Console.WriteLine("");
            }
            Console.ReadLine();
        }
    }
}
