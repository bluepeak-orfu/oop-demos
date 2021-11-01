using System;
using System.Collections.Generic;
using RepetitionVecka6;
using RepetitionVecka6.AbstraktDemo1;
using RepetitionVecka6.AbstraktDemo2;
using RepetitionVecka6.AbstraktDemo3;
using RepetitionVecka6.EnumDemo;

//// EnumDemo
//Console.WriteLine($"Enum value 1: {Direction.Left}");
//Direction enumVariabel = Direction.StraightAhead;
//Console.WriteLine($"Enum value 2: {enumVariabel}");

//SteeringWheel steeringWheel = new SteeringWheel();
//Console.WriteLine($"Currently going in direction: {steeringWheel.Steering}");
//steeringWheel.TurnLeft();
//Console.WriteLine($"Currently going in direction: {steeringWheel.Steering}");
//steeringWheel.TurnRight();
//Console.WriteLine($"Currently going in direction: {steeringWheel.Steering}");
//steeringWheel.TurnRight();
//Console.WriteLine($"Currently going in direction: {steeringWheel.Steering}");
//steeringWheel.TurnLeft();
//Console.WriteLine($"Currently going in direction: {steeringWheel.Steering}");

//List<Character> characters = new List<Character>()
//{
//    new Human(),
//    new Human(),
//    new Computer(),
//    new Computer(),
//    new Computer()
//};

//while (true)
//{
//    foreach (Character character in characters)
//    {
//        character.Move();
//    }

//    Console.WriteLine("Everyone moved");

//    foreach (Character character1 in characters)
//    {
//        Console.WriteLine($"Is now at {character1.X}, {character1.Y}");
//    }

//    System.Threading.Thread.Sleep(1000);
//}


//// Abstract class - fruit demo
//Person person = new Person();
//Fruit fruit1 = new Mango();
//Fruit fruit2 = new Lemon();
//person.Eat(fruit1);
//person.Eat(fruit2);


List<IConsoleAction> actions = new List<IConsoleAction>()
{
    new HelloAction(),
    new SumAction()
};
while (true)
{
    Console.WriteLine("What action do you want to do?");
    string actionCommand = Console.ReadLine();
    foreach (IConsoleAction action in actions)
    {
        if (action.CanDoAction(actionCommand))
        {
            action.DoAction();
            break;
        }
    }
    //if (action == "say hello")
    //{
    //    Console.WriteLine("Hello!");
    //}
    //else if (action == "add numbers")
    //{
    //    int x = Convert.ToInt32(Console.ReadLine());
    //    int y = Convert.ToInt32(Console.ReadLine());
    //    Console.WriteLine($"Sum: {x + y}");
    //}
}
