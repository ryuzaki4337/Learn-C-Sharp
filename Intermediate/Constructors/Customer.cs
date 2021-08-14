using System;
namespace Constructors
{
    public class Customer : Person
    {
        public int ID;
        public string name;
        public int Age;

        public Customer()
        {
            
        }
        public Customer(int ID,string Name)
        {
            this.ID = ID;
            this.name = Name;
        }

        public Customer(int ID, string Name, int Age)
        {
            this.ID = ID;
            this.name = Name;
            this.Age = Age;            
        }

        public void display()
        {
            Console.WriteLine("The name of the customer is {0} and the ID is {1}",this.name,this.ID);
        }

        public void display2()
        {
            Console.WriteLine("The name of the customer is {0}, the ID is {1} and the age of the customer is {2}",this.name,this.ID, this.Age);          
        }
    }
}
