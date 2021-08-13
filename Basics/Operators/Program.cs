using System;

namespace Operators
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 10;
            int b = 20;

            Console.WriteLine(a+b);
            Console.WriteLine(a-b);
            Console.WriteLine(a*b);
            Console.WriteLine(a/b);
            Console.WriteLine(a%b);
            Console.WriteLine(a++);
            Console.WriteLine(a);
            Console.WriteLine(++b);
            Console.WriteLine(b);
            Console.WriteLine(a==b);
            Console.WriteLine(b!=a);
            Console.WriteLine(a>=b);
            Console.WriteLine(a<=b);

            var c = 3;
            c += 5;
            Console.WriteLine(c);
            
            
            Console.WriteLine(c>b && c==a);
            Console.WriteLine(c>b || c==a);
            Console.WriteLine(!(c>b || c==a));
        }
    }
}
