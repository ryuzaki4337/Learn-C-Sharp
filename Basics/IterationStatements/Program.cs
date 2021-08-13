using System;

namespace IterationStatements
{
    public class ForClass
    {
        public void loop(int a)
        {
            Console.WriteLine("For loop:");
            for(int i=a;i<10;i++)
            {
                Console.WriteLine(i);
            }
        }
    }

    public class WhileClass
    {
        public void loop(int a)
        {
            Console.WriteLine("While loop");
            while(a<20)
            {
                Console.WriteLine(a);
                a++;
            }
        }
    }

    public class DoWhileClass
    {
        public void loop(int a)
        {
            Console.WriteLine("Do-While loop");
            do            {
                Console.WriteLine(a);
                a++;
            }while(a<30);
        }
    }

    public class ForEachClass{
        public void loop(int[] A)
        {
            Console.WriteLine("For each loop");
            foreach(var i in A)
            {
                Console.WriteLine(i);
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            ForClass obj1 = new ForClass();
            obj1.loop(1);

            WhileClass obj2 = new WhileClass();
            obj2.loop(11);

            int[] a = new int[3] {1,2,3};
            ForEachClass obj3 = new ForEachClass();
            obj3.loop(a);

            DoWhileClass obj4 = new DoWhileClass();
            obj4.loop(21);
        }
    }
}
