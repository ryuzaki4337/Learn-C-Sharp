using System;

namespace Timespan
{
    class Program
    {
        static void Main(string[] args)
        {
            var timeSpan = new TimeSpan(1,2,3);

            var timeSpan1 = new TimeSpan(1,0,0);
            var timeSpan2 = TimeSpan.FromHours(1);

            var start = DateTime.Now;
            var end = DateTime.Now.AddMinutes(30);

            var duration = end - start;

            Console.WriteLine("Time between start and end :" + duration);

            Console.WriteLine("Minutes :" + timeSpan.Minutes);
            Console.WriteLine("Hourse :" + timeSpan.Hours);

            Console.WriteLine("Adding mins : " + timeSpan.Add(TimeSpan.FromMinutes(10)));
            Console.WriteLine("Subtracting mins : " + timeSpan.Subtract(TimeSpan.FromMinutes(5)));

            Console.WriteLine("Timespan : " + timeSpan.ToString());

            Console.WriteLine("Parsing timespan : " + TimeSpan.Parse("01:02:03"));

        }
    }
}
