using System;

namespace Inheritance
{
    public class Parent
    {
        private string _parentName {get;set;}
        private int _parentAge{get;set;}

        public void parentClass()
        {
            Console.WriteLine("I'm inside parent class");
        }
    }
}
