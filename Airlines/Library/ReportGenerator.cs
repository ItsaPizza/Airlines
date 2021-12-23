using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    public class ReportGenerator
    {
        private AircraftRepository _aircraftRepository;
        private AircraftModelRepository _aircraftModelRepository;
        private CompanyRepository _companyRepository;
        private CountryRepository _countryRepository;

        public ReportGenerator
            (AircraftRepository aircraftRepository, 
            AircraftModelRepository aircraftModelRepository, 
            CompanyRepository companyRepository, 
            CountryRepository countryRepository)
        {
            _aircraftRepository = aircraftRepository;
            _aircraftModelRepository = aircraftModelRepository;
            _companyRepository = companyRepository;
            _countryRepository = countryRepository;
        }
        public List<ReportItem> GenerateReportAircraftInEurope()
        {
            List<Aircraft> aircrafts = _aircraftRepository.Retrieve();
            List<int> aircraftIdsFromEurope = new List<int>();

            
            foreach (var aircraft in aircrafts)
            {
                var companyId = aircraft.CompanyId;
                var company = _companyRepository.Retrieve(companyId);
                //if (company == null) { continue; }
                var countryId = company.CountryId;
                var country = _countryRepository.Retrieve(countryId);
                var continent = country.Continent;
                if (continent == "Europe")
                {
                    aircraftIdsFromEurope.Add(aircraft.Id);
                }
            }
            List<ReportItem> ataskaita = new List<ReportItem>();

            foreach (var id in aircraftIdsFromEurope)
            {
                var reportItem = new ReportItem();
                var aircraft = _aircraftRepository.Retrieve(id);
                reportItem.AircraftTailNumber = aircraft.TailNumber; //TAIL NR
                var aircraftModel = _aircraftModelRepository.Retrieve(aircraft.ModelId);
                reportItem.ModelNumber = aircraftModel.Number; //Model NR
                reportItem.ModelDescription = aircraftModel.Description; // Model Description
                var companyId = aircraft.CompanyId;
                var company = _companyRepository.Retrieve(companyId);
                reportItem.OwnerCompanyName = company.Name; //Company Name
                var countryId = company.CountryId;
                var country = _countryRepository.Retrieve(countryId);
                reportItem.CompanyCountryCode = country.Code; // Country Code
                reportItem.CompanyCountryName = country.Name; // Country Name
                reportItem.BelongsToEU = country.BelongsToEU;
                ataskaita.Add(reportItem);                
            }

            return ataskaita;
        }

    }
}
