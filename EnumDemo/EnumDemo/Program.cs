using System;
using EnumDemo;

Direction myDirection = Direction.North;

if (myDirection == Direction.South)
{
    Console.WriteLine("Going south");
}

switch (myDirection)
{
    case Direction.North:
        break;
    case Direction.East:
        break;
    case Direction.South:
        Console.WriteLine("Going south");
        break;
    case Direction.West:
        break;
}
