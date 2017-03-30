using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Expression2SqlTest
{
    class UserCity :BaseEntiy
    {
        public int CityId { get; set; }
        public int UserId { get; set; }
        public string Name { get; set; }
    }
}
