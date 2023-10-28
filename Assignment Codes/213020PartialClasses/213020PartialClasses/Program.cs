using System;

namespace App
{
    public partial class PartialClass
    {
        private int x;
        private int y;

        public PartialClass(int x, int y)
        {
            this.x = x;
            this.y = y;
        }

        public void Print()
        {
            Console.WriteLine("Output values: {0}, {1}", x, y);
        }
    }

    class Test
    {
        public static void Main()
        {
            PartialClass p = new PartialClass(10, 15);
            p.Print();
            Console.ReadLine();
        }
    }
}
