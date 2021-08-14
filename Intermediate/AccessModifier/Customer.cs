using System;
namespace AccessModifier
{
    public class Customer
    {
        public string name {get;set;}

        public void getName()
        {
            Console.WriteLine("The name of the customer is " + this.name);
        }

        public int customerID{get;set;}

        protected void getID()
        {
            Console.WriteLine("The ID of the customer is : " + this.customerID);
        }
    }
}
