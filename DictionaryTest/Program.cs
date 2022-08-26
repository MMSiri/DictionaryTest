using System;
using System.Collections.Generic;

namespace DictionaryTest
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> favouriteFoods = new Dictionary<string, string>();
            favouriteFoods["Dimitri"] = "pizza";
            favouriteFoods["David"] = "ramen";
            favouriteFoods["Gavin"] = "spaghetti";
            favouriteFoods["Stacy"] = "macaron";

            string name;

            while ((name = Console.ReadLine()) != "")
            {
                if (favouriteFoods.ContainsKey(name))
                    Console.WriteLine($"{name}'s favourite food is {favouriteFoods[name]}");
                else
                    Console.WriteLine($"I don't know {name}'s favourite food");
            }

        }
    }
}
