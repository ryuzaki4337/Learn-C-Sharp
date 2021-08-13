namespace Class
{
    class Program
    {
        static void Main(string[] args)
        {
            Calculator calciObj = new Calculator();

            int a = 10;
            int b = 20;

            calciObj.add(a,b);
            calciObj.sub(a,b);
            calciObj.mul(a,b);
            calciObj.mod(a,b);
        }
    }
}
