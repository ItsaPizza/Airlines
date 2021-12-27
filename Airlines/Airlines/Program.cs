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
            List<ReportItem> ataskaita = new List<ReportItem>();
            Console.WriteLine("Please enter selection where you wish to withdraw report from: [1] - Europe, [2] - Other Continent");
            int choice = Convert.ToInt32(Console.ReadLine());
            switch (choice)
            {
                case 1:
                    ataskaita = reportGenerator.GenerateReportAircraftInEurope();
                    break;
                case 2:
                    ataskaita = reportGenerator.GenerateReportAircraftOtherContinents();
                    break;
                default:
                    Console.WriteLine("Invalid selection");
                    break;
            }
            
            var htmlFormatter = new HTMLFormatter();
            string html = htmlFormatter.FormatHTML(ataskaita);
            Console.WriteLine(html);
            var emailSender = new EmailSender();
            emailSender.Sent("Test Title", html);

            Console.ReadLine();
        }
        

    }
}
