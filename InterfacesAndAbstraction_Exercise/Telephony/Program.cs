using System;

namespace Telephony
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            string[] numbers = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);
            string[] sites = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);
            Smartphone smartphone = new Smartphone();
            ICallable stationary = new Stationary();
            foreach (var num in numbers)
            {
                if (num.Length == 7)
                {
                    stationary.Call(num);
                }
                else
                {
                    smartphone.Call(num);
                }
            }

            foreach (var site in sites)
            {
                smartphone.Browse(site);
            }
        }
    }
}
