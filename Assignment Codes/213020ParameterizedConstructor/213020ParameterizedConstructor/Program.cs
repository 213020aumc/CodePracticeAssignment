using System;

namespace ConsoleApplication3
{
    class Sample
    {
        public string param1, param2;

        public Sample(string x, string y)
        {
            param1 = x;
            param2 = y;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Sample obj = new Sample("Welcome", "Asp.Net");
            Sample obj1 = new Sample("Welcome1", "Asp.Net");

            Console.WriteLine(obj.param1 + " to " + obj.param2);
            Console.WriteLine(obj1.param1 + " to " + obj1.param2);

            Console.ReadLine();
        }
    }
}
