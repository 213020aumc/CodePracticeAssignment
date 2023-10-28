using System;

namespace BinaryOverload
{
    class ComplexNumber
    {
        int real;
        double imaginary;

        public ComplexNumber(int real, double imaginary)
        {
            this.real = real;
            this.imaginary = imaginary;
        }

        public ComplexNumber()
        {
        }

        public static ComplexNumber operator +(ComplexNumber c1, ComplexNumber c2)
        {
            ComplexNumber c = new ComplexNumber();
            c.real = c1.real + c2.real;
            c.imaginary = c1.imaginary + c2.imaginary;
            return c;
        }

        public void Show()
        {
            Console.Write(real);
            Console.Write("+j" + imaginary);
            Console.WriteLine();
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            ComplexNumber p, q, r;
            p = new ComplexNumber(10, 2.0);
            q = new ComplexNumber(20, 15.5);
            r = p + q;

            Console.Write("p = ");
            p.Show();
            Console.Write("q = ");
            q.Show();
            Console.Write("r = ");
            r.Show();

            Console.ReadLine();
        }
    }
}
