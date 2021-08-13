using System.Collections.Generic;
using System;

namespace Lists
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = new List<int>(){1,2,3,4};
            numbers.Add(5);
            numbers.AddRange(new int[4]{6,7,8,1});

            foreach (var item in numbers)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine(numbers.IndexOf(1));

            Console.WriteLine(numbers.LastIndexOf(1));

            Console.WriteLine(numbers.Count);

            numbers.Remove(1);
            foreach (var item in numbers)
            {
                Console.WriteLine(item);
            }

            numbers.Clear();

            Console.WriteLine(numbers.Count);
            
        }
    }
}
