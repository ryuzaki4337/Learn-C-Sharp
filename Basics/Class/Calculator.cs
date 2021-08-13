using System;

namespace Class
{
    public class Calculator{
        public void add(int a, int b)
        {
            Console.WriteLine("The sum of the integers is : {0}",a+b);
        }
        public void sub(int a, int b)
        {
            Console.WriteLine("The difference of the integers is : {0}",a-b);
        }
        public void mul(int a, int b)
        {
            Console.WriteLine("The product of the integers is : {0}",a*b);
        }
        public void mod(int a, int b)
        {
            Console.WriteLine("The mod of the integers is : {0}",a%b);
        }
    }
}
