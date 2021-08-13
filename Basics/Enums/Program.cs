using System;

namespace Enums
{
    class Program
    {

        public enum Months{
            jan = 1,
            feb,
            mar,
            apr,
            may,
            june,
            july,
            aug,
            sept,
            oct,
            nov,
            dec
        }
        static void Main(string[] args)
        {
            var octMonthNumber = Months.oct;
            Console.WriteLine((int)octMonthNumber);
        }
    }
}
