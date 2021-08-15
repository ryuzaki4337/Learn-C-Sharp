using System;
namespace Polymorphism
{
    public class Customer : Person
    {

        override
        public void Display() => Console.WriteLine("Customer class");
    }
}
