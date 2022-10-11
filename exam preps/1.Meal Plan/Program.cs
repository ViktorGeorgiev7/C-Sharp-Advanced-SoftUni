using System;
using System.Collections.Generic;
using System.Linq;

namespace _1.Meal_Plan
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> dictionary = new Dictionary<string, int>
            {
                {"salad", 350},
                {"soup", 490},
                {"pasta", 680},
                {"steak", 790}
            };

            string[] meals = Console.ReadLine()?
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .ToArray();
            int[] calories = Console.ReadLine()?
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
            Queue<int> mealPlan = new Queue<int>();
            foreach (var meal in meals)
            {
                if (dictionary.ContainsKey(meal))
                {
                    mealPlan.Enqueue(dictionary[meal]);
                }
            }
            Stack<int> caloriePlan = new Stack<int>(calories);

            while (true)
            {
                if (!mealPlan.Any())
                {
                    Console.WriteLine($"John had {meals.Length} meals.");
                    Console.WriteLine($"For the next few days, he can eat {string.Join(", ",caloriePlan)} calories.");
                    break;
                }

                if (!caloriePlan.Any())
                {
                    Console.WriteLine($"John ate enough, he had {meals.Length} meals.");
                    Console.WriteLine($"Meals left: {string.Join(", ",mealPlan)}.");
                    break;
                }

                if (mealPlan.Peek() < caloriePlan.Peek())
                {
                    int cals = caloriePlan.Pop();
                    int meal = mealPlan.Dequeue();
                    caloriePlan.Push(cals-meal);
                }
                else//in all other cases meals will be bigger than the daily calorie intake
                {
                    int cals = caloriePlan.Pop();
                    int meal = mealPlan.Dequeue();
                    mealPlan.Enqueue(meal-cals);
                }
            }

        }
    }
}
