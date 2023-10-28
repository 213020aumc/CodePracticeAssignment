using System;

class Bank
{
    int x;
    int y;

    public Bank(int a, int b)
    {
        x = a;
        y = b;
    }

    public Bank()
    {
    }

    public void Display()
    {
        Console.Write(" " + x);
        Console.Write(" " + y);
        Console.WriteLine();
    }

    public static Bank operator -(Bank b)
    {
        b.x = -b.x;
        b.y = -b.y;
        return b;
    }
}

class Program
{
    public static void Main()
    {
        Bank ba1 = new Bank(10, -20);
        ba1.Display();

        Bank ba2 = new Bank();
        ba2.Display();

        ba2 = -ba1;
        ba2.Display();

        Console.ReadLine();
    }
}
