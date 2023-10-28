using System;

delegate void MyDelegate();

namespace DelegateApp1
{
    class MyMethods
    {
        static public void Display()
        {
            Console.WriteLine("New Delhi");
        }

        static public void Print()
        {
            Console.WriteLine("New York");
        }
    }

    class DelegateTest
    {
        public static void Main()
        {
            MyDelegate m1 = new MyDelegate(MyMethods.Display);
            MyDelegate m2 = new MyDelegate(MyMethods.Print);

            MyDelegate m3 = m1 + m2; // Combine m1 and m2 in this order
            MyDelegate m4 = m3;       // m4 has the same delegates as m3
            MyDelegate m5 = m3 - m2; // Remove m2 from m3

            m3();
            m4();
            m5();
        }
    }
}
