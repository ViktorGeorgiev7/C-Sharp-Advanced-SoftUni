using System;
using System.Collections.Generic;
using System.Text;

namespace MilitaryElite
{
    public interface IPrivate
    {
        public string Id { get; }
        public string FirstName { get;}
        public string LastName { get;}
        public decimal Salary { get;}
    }
}
