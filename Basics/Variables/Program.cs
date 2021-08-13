using System;

namespace Variables
{
    class Program
    {
        static void Main(string[] args)
        {
            byte byteVar = 1;
            Console.WriteLine(byteVar);

            int intVar = 10;
            Console.WriteLine(intVar);
            
            float floatVar = 1.2f;
            Console.WriteLine(floatVar);
            
            char charVar = 'A';
            Console.WriteLine(charVar);
            
            bool boolVar = true;
            Console.WriteLine(boolVar);
            
            string stringVar = "Lalithaditya";
            Console.WriteLine(stringVar);

            var detectVar = "C_sharp is a cool language";
            Console.WriteLine(detectVar);

            Console.WriteLine("My name is {0}",stringVar);
        }
    }
}
