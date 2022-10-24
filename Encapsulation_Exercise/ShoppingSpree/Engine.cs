using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ShoppingSpree
{
    public class Engine
    {
        public void Start()
        {
            char[] delimiters = {'=', ';', ' '};
            string[] peopleArr = Console.ReadLine().Split(delimiters, StringSplitOptions.RemoveEmptyEntries);
            List<Person> people = new List<Person>();
            try
            {
                for (int i = 0; i < peopleArr.Length; i++)
                {
                    if (int.Parse(peopleArr[i + 1]) >= 0)
                    {
                        if (!(string.IsNullOrEmpty(peopleArr[i]) && string.IsNullOrWhiteSpace(peopleArr[i])))
                        {
                            people.Add(new Person(peopleArr[i], int.Parse(peopleArr[i + 1])));
                        }
                        else
                        {
                            throw new ArgumentException("Name cannot be empty");
                        }
                    }
                    else
                    {
                        throw new ArgumentException("Money cannot be negative");
                    }
                    i++;
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            string[] productArr = Console.ReadLine().Split(delimiters, StringSplitOptions.RemoveEmptyEntries);
            List<Product> products = new List<Product>();
            try
            {
                for (int i = 0; i < productArr.Length; i++)
                {
                    if (int.Parse(productArr[i + 1]) > 0)
                    {
                        if (!string.IsNullOrEmpty(productArr[i]))
                        {
                            products.Add(new Product(productArr[i], int.Parse(productArr[i + 1])));
                        }
                        else
                        {
                            Console.WriteLine("Name cannot be empty");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Money cannot be negative");
                    }
                    i++;
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            
            string input = Console.ReadLine();
            while (input != "END")
            {
                string[] placeHolders = input.Split(' ',StringSplitOptions.RemoveEmptyEntries);
                foreach (Person person in people)
                {
                    if (person.Name == placeHolders[0])
                    {
                        foreach (Product product in products)
                        {
                            if (product.Name == placeHolders[1])
                            {
                                if (person.Money >= product.Cost)
                                {
                                    person.Money -= product.Cost;
                                    Console.WriteLine($"{person.Name} bought {product.Name}");
                                    person.Bag.Add(product);
                                }
                                else
                                {
                                    Console.WriteLine($"{person.Name} can't afford {product.Name}");
                                }
                            }
                        }
                    }
                }
                input = Console.ReadLine();
            }

            foreach (Person person in people)
            {
                if (person.Bag.Count > 0)
                {
                    Console.WriteLine($"{person.Name} - {string.Join(", ",person.Bag.Select(x=>x.Name))}");
                }
                else
                {
                    Console.WriteLine($"{person.Name} - Nothing bought");
                }
            }
           
        }
    }
}
