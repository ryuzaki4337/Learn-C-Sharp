using System;

namespace TypeConversion
{
    class Program
    {
        static void Main(string[] args)
        {
            //  Implicit Conversion
            byte b = 1;
            int i = b;
            Console.WriteLine(b); 
            Console.WriteLine(i);

            // Explicit Conversion
            float f = 2.3f;
            int v = (int)f;
            Console.WriteLine(f);
            Console.WriteLine(v);

            // Non-compatible data types

            string str = "1";
            int m = Convert.ToInt32(str);
            int n = int.Parse(str);
            Console.WriteLine(m);
            Console.WriteLine(n);

        }
    }
}
