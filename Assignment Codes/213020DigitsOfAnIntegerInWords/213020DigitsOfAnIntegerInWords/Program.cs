using System;

namespace Application
{
    class Program
    {
        public static void Main(string[] args)
        {
            int num, nextDigit, numDigits;
            int[] n = new int[20];
            string[] digits = { "Zero", "One", "Two", "Three", "Four", "Five", "Six", "Seven", "Eight", "Nine" };

            Console.WriteLine("Enter the Number: ");
            num = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Number: " + num);
            Console.WriteLine("Number in Words: ");

            nextDigit = 0;
            numDigits = 0;

            do
            {
                nextDigit = num % 10;
                n[numDigits] = nextDigit;
                numDigits++;
                num = num / 10;
            }
            while (num > 0);

            numDigits--;

            for (; numDigits >= 0; numDigits--)
            {
                Console.Write(digits[n[numDigits]] + " ");
            }

            Console.ReadLine();
        }
    }
}
