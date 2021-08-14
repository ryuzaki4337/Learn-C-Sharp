using System;

namespace dateTime
{
    class Program
    {
        static void Main(string[] args)
        {
            var dateTimeObj = new DateTime(2015,1,1);
            var nowTime = DateTime.Now;
            var todayDate = DateTime.Today;

            Console.WriteLine("Present Time : {0} hr, {1} min, {2} secs", nowTime.Hour,nowTime.Minute,nowTime.Second);

            Console.WriteLine("Present day : {0} day, {1} month, {2} year", todayDate.Day,todayDate.Month,todayDate.Year);

            var tomorrow = todayDate.AddDays(1);
            var yesterday = todayDate.AddDays(-1);

            Console.WriteLine(nowTime.ToLongDateString());
            Console.WriteLine(nowTime.ToShortDateString());
            Console.WriteLine(nowTime.ToLongTimeString());
            Console.WriteLine(nowTime.ToShortTimeString());
            Console.WriteLine(nowTime.ToString());

            
        }
    }
}
