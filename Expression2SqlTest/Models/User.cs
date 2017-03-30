using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Expression2SqlTest
{
    class UserInfo : BaseEntity
    {
        
        public int Sex { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
    }
}
