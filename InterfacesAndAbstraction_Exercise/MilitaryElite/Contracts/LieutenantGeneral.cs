using System;
using System.Collections.Generic;
using System.Text;

namespace MilitaryElite.Contracts
{
    class LieutenantGeneral : ILieutenantGeneral
    {
        public List<Private> Privates { get; }
        public string Id { get; }

        public string FirstName { get; }

        public string LastName { get; }

        public decimal Salary { get; }
    }
}
