using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace Telephony
{
    public class Stationary:ICallable
    {
        public void Call(string number)
        {
            foreach (char character in number)
            {
                if (!char.IsNumber(character))
                {
                    Console.WriteLine("Invalid number!");
                    return;
                }
            }
            Console.WriteLine($"Dialing... {number}");
        }
    }
}
