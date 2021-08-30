using System;

namespace Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            // Single dimensional arrays
            int[] S = new int[3];
            S[0] = 1;
            S[1] = 2;
            S[2] = 3;

            Console.WriteLine(S[0]);
            Console.WriteLine(S[1]);
            Console.WriteLine(S[2]);

            Console.WriteLine("All okay");

            string[] stringArray = new string[3] {"Jack","Jill","Mary"};

            Console.WriteLine(stringArray[0]);
            Console.WriteLine(stringArray[1]);
            Console.WriteLine(stringArray[2]);
            
            // Length
            Console.WriteLine(S.Length);

            // IndexOf
            var index=  Array.IndexOf(S,2);
            Console.WriteLine(index);

            // Clear
            Array.Clear(S,0,1);
            foreach(var i in S)
            {
                Console.WriteLine(i);
            }

            // Copy
            int[] b = new int[2];
            Array.Copy(S,b,2);
            foreach(var i in b)
            {
                Console.WriteLine(i);
            }
            
            // Sort
            Array.Sort(S);
            foreach(var i in S)
            {
                Console.WriteLine(i);
            }

            // Reverse
            Array.Reverse(S);
            foreach(var i in S)
            {
                Console.WriteLine(i);
            }         

        }
    }
}
