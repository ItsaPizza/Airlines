using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    public class Company
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int? CountryId { get; set; }

        public Company() { }
        public Company(int id, string name, int? countryId)
        {
            Id = id;
            Name = name;
            CountryId = countryId;
        }

    }
}
