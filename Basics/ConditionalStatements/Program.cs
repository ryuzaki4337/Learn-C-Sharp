using System;

namespace ConditionalStatements
{
    public class IfElse
    {
        public void checkUsingIfElse(int x)
        {
            if(x>10)
            {
                Console.WriteLine("The number is greater than 10");
            }
            else if(x<10)
            {
                Console.WriteLine("The number is lesser than 10");
            }
            else
            {
                Console.WriteLine("The number is equal to 10");
            }
        }
    }

    public class SwitchStatement{
        public void checkUsingSwitch(int x)
        {
            switch(x%2)
            {
                case 0 : Console.WriteLine("Given number is even"); break;
                case 1 : Console.WriteLine("Given number is odd"); break;
                default : Console.WriteLine("Given number is neither odd nor even");break;
            }

        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            
            IfElse obj1 = new IfElse();
            obj1.checkUsingIfElse(9);
            obj1.checkUsingIfElse(10);
            obj1.checkUsingIfElse(11);

            SwitchStatement obj2 = new SwitchStatement();
            obj2.checkUsingSwitch(10);
            obj2.checkUsingSwitch(9);
        }
    }
}
