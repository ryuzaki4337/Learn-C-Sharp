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

            var myName2 = "Lalithaditya Kota     ";
            var trimmedName = myName2.Trim();
            Console.WriteLine("Trimming my name : " + trimmedName);

            Console.WriteLine("Uppercase : " + trimmedName.ToUpper());
            Console.WriteLine("Lowercase : " + trimmedName.ToLower());

            var index2 = trimmedName.IndexOf('K');
            var index3 = trimmedName.IndexOf("Kota");

            Console.WriteLine("Index of a character :" + index2);
            Console.WriteLine("Index of a string :" + index3);

            var subString1 = trimmedName.Substring(13);
            var substring2 = trimmedName.Substring(0,12);

            Console.WriteLine("First Name : " + subString1);
            Console.WriteLine("Surname : " + substring2);

            var names = trimmedName.Split(' ');

            foreach (var item in names)
            {
                Console.WriteLine(item);
            }

            var replacedString = trimmedName.Replace('K','k');
            var newReplacedString = trimmedName.Replace("Lalithaditya","Yashwanth");

            Console.WriteLine("Replacing characters : " + replacedString);
            Console.WriteLine("Replacing Strings : " + newReplacedString);

            Console.WriteLine("Checking whether the string is empty or null : " + String.IsNullOrEmpty(trimmedName));
            Console.WriteLine("Checking whether the string is whitespace or null : " + String.IsNullOrWhiteSpace("   "));

            int a = 56;

            Console.WriteLine("Number to String conversion : " + a.ToString());

            string str2 = "45";
            Console.WriteLine("String to Number conversion : " + Convert.ToInt32(str2));

        }
    }
}
