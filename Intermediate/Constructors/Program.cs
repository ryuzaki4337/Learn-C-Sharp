using System;

namespace Constructors
{
    public class Person
    {
        private readonly string _address;

        public Person(string address)
        {
            _address = address;

            Console.WriteLine("The address of the person is : " + _address);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            // var customer = new Customer(1,"Hema");
            // customer.display();
            // customer.display2();

            // var customer2 = new Customer(2,"Yashpal",35);
            // customer2.display();
            // customer2.display2();

            // var customer3 = new Customer
            //                 {
            //                     ID = 3,
            //                     name = "Jithu",
            //                     Age = 25
            //                 };
            // customer3.display();
            // customer3.display2();

            var customer = new customer()
        }
    }
}
