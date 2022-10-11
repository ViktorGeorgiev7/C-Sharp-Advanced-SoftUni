using System;
using System.Collections.Generic;
using System.Text;

namespace BirthdayCelebrations
{
    public interface IBirthable
    {
        string Name { get; set; }
        string Day { get; set; }
        string Month { get; set; }
        int Year { get; set; }
    }
}
