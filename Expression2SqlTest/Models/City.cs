using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Expression2SqlTest
{
    class City :BaseEntity
    {
       
        public int CountryId { get; set; }
        public string CityName { get; set; }
    }
}
