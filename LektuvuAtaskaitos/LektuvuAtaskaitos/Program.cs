using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LektuvuAtaskaitos_bussinessLogic;

namespace LektuvuAtaskaitos
{
    class Program
    {
        static void Main(string[] args)
        {
            ReportGenerator reportGenerator = new ReportGenerator(new AircraftRepository(),
                new AircraftModelRepository(),
                new CompanyRepository(),
                new CountryRepository());

            List<ReportItem> ataskaita = reportGenerator.GenerateReportAircraftInEurope();
            foreach (var eilute in ataskaita)
            {
                Console.WriteLine("{0}, {1}, {2}, {3}, {4}, {5}, {6}, {7}",
                    eilute.AircraftTailNumber, 
                    eilute.ModelNumber, 
                    eilute.ModelDescription, 
                    eilute.OwnerCompanyName,
                    eilute.CompanyCountryCode,
                    eilute.CompanyCountryName,
                    eilute.BelongsToES,
                    eilute.BelongsToEU);
            }
            Console.ReadLine();
        }
    }
}
