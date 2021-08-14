using System;

namespace AccessModifier
{
    public class Consumer : Customer
    {
        public string consumedProduct {get;set;}

        public void getProduct()
        {
            Console.WriteLine("The product which is purchased by the {0} is {1}", this.name,this.consumedProduct);
        }

        public int consumerAge {get;set;}

        private void getAge()
        {
            Console.WriteLine("The age of the {0} is {1}",this.name, this.consumerAge);
        }

        public void getConsumerID()
        {
            getID();
        }
    }
}
