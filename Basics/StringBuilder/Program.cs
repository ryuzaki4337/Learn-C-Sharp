using System;
using System.Text;

namespace stringBuilder
{
    class Program
    {
        static void Main(string[] args)
        {
            var stringB = new StringBuilder();
            stringB.Append('-',10);
            stringB.AppendLine();
            stringB.Append("Lalithaditya");
            stringB.AppendLine();
            stringB.Append('-',10);


            stringB.Replace('-','+');
            Console.WriteLine(stringB);

            stringB.Remove(0,10);
            Console.WriteLine(stringB);

            stringB.Insert(0,new string("+"),10);
            Console.WriteLine(stringB);

            stringB
                .AppendLine()
                .Append('*',10)
                .Append("Yashwanth Kota")
                .AppendLine()
                .Append('*',10);

            Console.WriteLine(stringB);
        }
    }
}
