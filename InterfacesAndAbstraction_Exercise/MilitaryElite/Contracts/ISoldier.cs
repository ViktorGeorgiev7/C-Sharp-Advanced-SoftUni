using System;
using System.Collections.Generic;
using System.Text;

namespace MilitaryElite
{
    public interface ISoldier//id, first name, and last name
    {
        public string Id { get;}
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }
}
