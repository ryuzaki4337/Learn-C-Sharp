using System;

namespace Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] S = new int[3];
            S[0] = 1;
            S[1] = 2;
            S[2] = 3;

            Console.WriteLine(S[0]);
            Console.WriteLine(S[1]);
            Console.WriteLine(S[2]);

            string[] stringArray = new string[3] {"Jack","Jill","Mary"};

            Console.WriteLine(stringArray[0]);
            Console.WriteLine(stringArray[1]);
            Console.WriteLine(stringArray[2]);
        }
    }
}
