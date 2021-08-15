using System;
namespace Polymorphism
{
    class Program
    {
        static void Main(string[] args)
        {
            var obj = new Customer();
            obj.Display();

            var obj2 = new Consumer();
            obj2.Display();
        }
    }
}
