using System;
using System.Collections.Generic;

namespace CollectionsPractice
{
    public class Program
    {
        static void Main(string[] args)
        {
            int[] numArray = {1,2,3,4,5,6,7,8,9};
            string[] namesArray = {"Tim", "Martin", "Nikki", "Sara"};
            string[] names = new string[]
            {
                "Tim", "Martin", "Nikki", "Sara"
            };

            bool[] boolArray = {true, false, true, false, true, false, true, false, true, false};

            bool[] boolies = new bool[10];
            for(var i = 0; i<boolies.Length; i++)
            {
                boolies[i] = i % 2 == 0;
            }

            for(var i = 0; i<boolies.Length; i++)
            {
                Console.WriteLine($"Boolies{i} is {boolies[i]}");
            }
            var iceCream = new List<string> {"vanilla", "chocolate", "mint", "sherbert", "orange"};
            Console.WriteLine(iceCream[2]);
            Console.WriteLine(iceCream.Count);
            iceCream.Remove("mint");
            Console.WriteLine(iceCream[2]);
            Console.WriteLine(iceCream.Count());

            Dictionary<string, string> personIcecream = new Dictionary<string, string>();
            personIcecream.Add(namesArray[1], iceCream[2]);
            personIcecream.Add(namesArray[3], iceCream[1]);
            personIcecream.Add(namesArray[2], iceCream[3]);
            personIcecream.Add(namesArray[0], iceCream[0]);

            foreach(KeyValuePair<string, string> entry in personIcecream)
            {
                Console.WriteLine($"{entry.Key} - {entry.Value}");
            }
        }



    }
}