using System;

namespace Encapsulation
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer obj = new Customer();
            obj.setDetails("Teja");
            Console.WriteLine(obj.getDetails());
        }
    }
}
