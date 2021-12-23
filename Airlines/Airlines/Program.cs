using Library;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var aircraftRepository = new AircraftRepository();
            var aircraftModelRepository = new AircraftModelRepository();
            var companyRepository = new CompanyRepository();
            var countryRepository = new CountryRepository();
            var reportGenerator = new ReportGenerator(aircraftRepository, aircraftModelRepository, companyRepository, countryRepository);
            List<ReportItem> ataskaita = reportGenerator.GenerateReportAircraftInEurope();

            Console.ReadLine();
        }
    }
}
