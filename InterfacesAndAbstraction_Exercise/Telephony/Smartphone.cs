using System;
using System.Collections.Generic;
using System.Text;

namespace Telephony
{
    public class Smartphone:ICallable,IBrowsable
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
            Console.WriteLine($"Calling... {number}");
        }
        public void Browse(string site)
        {
            foreach (char character in site)
            {
                if (char.IsNumber(character))
                {
                    Console.WriteLine("Invalid URL!");
                    return;
                }
            }

            Console.WriteLine($"Browsing: {site}!");
        }
    }
}
