using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strukturos_Namu_darbai_Nr._4
{
    class Program
    {
        struct Skiepas
        {

            public DateTime SkiepoData;
            public string SkiepoPavadinimas;

           
        }

        static void Main(string[] args)
        {
            List<Skiepas> skiepai = new List<Skiepas>();
            Skiepas skiepuKalendorius1;
            Skiepas skiepuKalendorius2;
            Skiepas skiepuKalendorius3;
            Skiepas skiepuKalendorius4;

            skiepuKalendorius1.SkiepoData = new DateTime(2010, 01, 12);
            skiepuKalendorius1.SkiepoPavadinimas = "Nuo Gripo";

            skiepuKalendorius2.SkiepoData = new DateTime(2018, 04, 12);
            skiepuKalendorius2.SkiepoPavadinimas = "Nuo Erkių";
            skiepai.Add(skiepuKalendorius2);

            skiepuKalendorius3.SkiepoData = new DateTime(1990, 12, 19);
            skiepuKalendorius3.SkiepoPavadinimas = "Nuo Vėjarupių";
            skiepai.Add(skiepuKalendorius3);

            skiepuKalendorius4.SkiepoData = new DateTime(2001, 06, 21);
            skiepuKalendorius4.SkiepoPavadinimas = "Nuo Gripo 2";
            skiepai.Add(skiepuKalendorius4);


            int result = DateTime.Compare(skiepuKalendorius1.SkiepoData, skiepuKalendorius2.SkiepoData);
       
            DateTime max = new DateTime();

            if (result > 0)
            {
                max = skiepuKalendorius1.SkiepoData;
            }
            else if (result == 0)
            {
                max = skiepuKalendorius1.SkiepoData;
            }
            else
            {
                max = skiepuKalendorius2.SkiepoData;
            }


            int result2 = DateTime.Compare(skiepuKalendorius3.SkiepoData, skiepuKalendorius4.SkiepoData);
            DateTime max2 = new DateTime();
            if (result > 0)
            {
                max2 = skiepuKalendorius1.SkiepoData;
            }
            else if (result == 0)
            {
                max2 = skiepuKalendorius3.SkiepoData;
            }
            else
            {
                max2 = skiepuKalendorius4.SkiepoData;
            }


            if (max > max2)
            {
                Console.WriteLine("Paskutinis skiepas darytas {0}", max);
            }
            else
            {
                Console.WriteLine("Paskutinis skiepas darytas {0}", max2);
            }


            

            Console.WriteLine(skiepuKalendorius1.SkiepoPavadinimas + ", " + skiepuKalendorius2.SkiepoPavadinimas + ", " + skiepuKalendorius3.SkiepoPavadinimas + ", " + skiepuKalendorius4.SkiepoPavadinimas);
            Console.ReadLine();
        }
        
    }
}
