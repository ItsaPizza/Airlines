using Library;
using NUnit.Framework;

namespace UnitTest
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
            var aircraftRepository = new AircraftRepository();
            var aircraftModelRepository = new AircraftModelRepository();
            var companyRepository = new CompanyRepository();
            var countryRepository = new CountryRepository();
            var reportGenerator = new ReportGenerator(aircraftRepository, aircraftModelRepository, companyRepository, countryRepository);

        }

        [Test]
        public void Test1()
        {
            
            
            Assert.Pass();
        }
    }
}