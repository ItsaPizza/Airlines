using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    internal class Country
    {
        public int Id { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public string Continent { get; set; }
        public bool? BelongsToEU { get; set; }
        public Country() { }
        public Country(int id, string code, string name, string continent, bool? belongsToEU)
        {
            Id = id;
            Code = code;    
            Name = name;
            Continent = continent;
            BelongsToEU = belongsToEU;
        }

    }
}
