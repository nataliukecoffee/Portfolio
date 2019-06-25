using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MokinysBL;

namespace ConsoleApp1
{
    class Program
    {
      
        static void Main(string[] args)
        {

            Mokinys mokinys = new Mokinys(9, "Petras", true);
            Console.WriteLine(mokinys.Id);
            Console.WriteLine(mokinys.Vardas);

            mokinys.PazymiuSarasas.Add(10);
            mokinys.PazymiuSarasas.Add(9);
            mokinys.PazymiuSarasas.Add(2);
            mokinys.PazymiuSarasas.Add(10);
            mokinys.PazymiuSarasas.Add(10);

            foreach (var pazymis in mokinys.PazymiuSarasas)
            {
                Console.WriteLine("{0}", pazymis);
            }
            Console.WriteLine(mokinys.PazymiuVidurkis());
            

            MokinioRepository repo = new MokinioRepository();
            List<Mokinys> mokiniai = repo.Retrieve();

            foreach (var vienasMokinys in mokiniai)
            {
                Console.WriteLine("{0}, {1}, {2}",  vienasMokinys.Id, vienasMokinys.Vardas, vienasMokinys.OlimpiaduNugaletojas);
                
            }

            Mokinys treciasMokinys = repo.Retrieve(3);
            Console.WriteLine("{0}, {1}", treciasMokinys.Id, treciasMokinys.Vardas);
            

            ReportGenerator reportGenerator = new ReportGenerator(new MokinioRepository());
            string mokiniuAtaskaita = reportGenerator.GeneruotiMokiniuAtaskaita();
            Console.WriteLine(mokiniuAtaskaita);
            Console.ReadLine();
            
        }
    }
}
