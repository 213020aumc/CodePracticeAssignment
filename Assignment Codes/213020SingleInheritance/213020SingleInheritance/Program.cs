using System;

namespace InheritanceApplication
{
    class A
    {
        public void Display()
        {
            Console.WriteLine("hahahaha");
        }
    }

    class B : A // B is a child of A
    {
        public void Display1()
        {
            Console.WriteLine("hihihih");
        }
    }

    class C
    {
        public static void Main()
        {
            B x = new B(); // Create an object of the child class
            x.Display();
            x.Display1();
        }
    }
}
