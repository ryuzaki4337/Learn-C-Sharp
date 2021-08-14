using System;

namespace Inheritance
{
    public class ChildClass : Parent
    {
        private string _childName {get;set;}

        private int _childAge {get;set;}

        public void childClass()
        {
            Console.WriteLine("I'm inside children class");    
        }
    }
}
