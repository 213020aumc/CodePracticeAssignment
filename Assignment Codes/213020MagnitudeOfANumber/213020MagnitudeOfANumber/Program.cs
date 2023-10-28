using System;

namespace Magnitude
{
    class Program
    {
        public static void Main(string[] args)
        {
            int n, i = 0;
            Console.WriteLine("Enter A Number: ");
            n = int.Parse(Console.ReadLine());

            while (n > 0)
            {
                i++;
                n = n / 10;
            }

            Console.WriteLine("Magnitude of the given number is: " + i);
        }
    }
}
