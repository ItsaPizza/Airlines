using HTML_Generator;
using Library;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
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
            var htmlFormatter = new HTMLFormatter();
            string html = htmlFormatter.FormatHTML(ataskaita);
            Console.WriteLine(html);
            var emailSender = new EmailSender();
            emailSender.Sent();

            Console.ReadLine();
        }
        

    }
}
