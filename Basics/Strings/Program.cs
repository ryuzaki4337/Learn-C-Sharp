using System;

namespace Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            string firstName = "Lalith";
            string lastName = "aditya";
            Console.WriteLine(firstName+lastName);

            string myName = firstName+lastName;
            Console.WriteLine(myName);

            string name = string.Format("{0}{1}",firstName,lastName);
            Console.WriteLine(name);

            int[] A = new int[3] {1,2,3};

            string arrString = string.Join(",",A);

            Console.WriteLine(arrString);

            Console.WriteLine(firstName[0]);

            string newLineString = "Hi,\n this is Lalithaditya";

            Console.WriteLine(newLineString);

            string verbatimNewLineString = @"Hi
            This is Lalithaditya Kota";

            Console.WriteLine(verbatimNewLineString);

        }
    }
}
