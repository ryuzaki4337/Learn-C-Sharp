using System;

namespace Classes
{
    public class Person{
        public string name;

        public void introduce(string to)
        {
            Console.WriteLine("Hi {0}, this is {1}",to,name);
        }

        public static Person parse(string str)
        {
            Person p = new Person();
            p.name = str;
            return p;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Person p1 = Person.parse("Lalithaditya");
            p1.introduce("Yashwanth");
        }
    }
}
