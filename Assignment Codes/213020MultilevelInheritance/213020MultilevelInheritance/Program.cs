using System;

namespace ConsoleApplication8
{
    class A
    {
        public void Display()
        {
            Console.WriteLine("hahahaha");
        }
    }

    class B : A
    {
        public void Display1()
        {
            Console.WriteLine("hihihih");
        }
    }

    class D : B
    {
        public void Display2()
        {
            Console.WriteLine("hohohohoh");
        }
    }

    class C
    {
        public static void Main()
        {
            D x = new D(); // Normally object of child
            x.Display();
            x.Display1();
            x.Display2();
        }
    }
}
