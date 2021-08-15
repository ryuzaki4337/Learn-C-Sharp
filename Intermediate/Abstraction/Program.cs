namespace Abstraction
{
    class Program
    {
        static void Main(string[] args)
        {
            var obj = new Customer();
            obj.Display();

            var obj3 = new Consumer();
            obj3.Display();
        }
    }
}
