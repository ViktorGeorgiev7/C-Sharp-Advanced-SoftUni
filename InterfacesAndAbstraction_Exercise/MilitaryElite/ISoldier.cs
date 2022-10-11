using System;
using System.Collections.Generic;
using System.Text;

namespace MilitaryElite
{
    interface ISoldier//(e.g. ISoldier should hold id, first name, and last name
    {
        public string Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }
}
