using System;

class EnumType
{
    enum Direction
    {
        North,
        East = 10,
        West,
        South
    }

    public static void Main()
    {
        Direction d1 = Direction.North;
        Direction d2 = Direction.East;
        Direction d3 = Direction.West;
        Direction d4 = (Direction)12;

        Console.WriteLine("d1 = " + (int)d1);
        Console.WriteLine("d2 = " + (int)d2);
        Console.WriteLine("d3 = " + (int)d3);
        Console.WriteLine("d4 = " + (int)d4);
    }
}
