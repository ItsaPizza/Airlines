using Library;
using NUnit.Framework;
using System.Collections.Generic;

namespace UnitTest
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {


        }

        [Test]
        public void Test1()
        {
            var aircraftRepository = new AircraftRepository();

            var aircraft = aircraftRepository.Retrieve(101);
            string expectedValue = "LY-SPH";
            string actualValue = aircraft.TailNumber;
            Assert.AreEqual(expectedValue, actualValue);

        }
        public void Test2()
        {
            var aircraftModelRepository = new AircraftModelRepository();

            var aircraftModel = aircraftModelRepository.Retrieve(9);
            string expectedValue = "Bombardier CRJ200";
            string actualValue = aircraftModel.Description;
            Assert.AreEqual(expectedValue, actualValue);
        }
        public void Test3()
        {
            var companyRepository = new CompanyRepository();

            var company = companyRepository.Retrieve(1082);
            int expectedValue = 201;
            int? actualValue = company.CountryId;
            Assert.AreEqual(expectedValue, actualValue);
        }
        public void Test4()
        {
            var countryRepository = new CountryRepository();

            var country = countryRepository.Retrieve(1);
            string expectedValue = "Lithuania";
            string actualValule = country.Name;
            Assert.AreEqual(expectedValue, actualValule);
        }
    }
}