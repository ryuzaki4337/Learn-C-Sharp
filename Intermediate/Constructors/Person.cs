using System;

namespace Constructors
{
    public class Person
    {
        private readonly string address;
        public Person(string address)
        {
            this.address = address;

            Console.WriteLine("The address of the person is " + address);
        }
    }
}
