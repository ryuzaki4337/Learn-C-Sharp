using System;

namespace AccessModifier
{
    class Program
    {
        static void Main(string[] args)
        {
            var obj = new Consumer();
            obj.consumedProduct = "Tata Salt";
            obj.name = "Aruna";
            obj.consumerAge = 48;
            obj.getProduct();
            obj.getName();
            //obj.getAge();

            obj.customerID = 1;
            obj.getConsumerID();
        }
    }
}
