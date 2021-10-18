using System;
using RepetitionVecka6;
using RepetitionVecka6.AbstraktDemo2;
using RepetitionVecka6.EnumDemo;

// EnumDemo
Console.WriteLine($"Enum value 1: {Direction.Left}");
Direction enumVariabel = Direction.StraightAhead;
Console.WriteLine($"Enum value 2: {enumVariabel}");

SteeringWheel steeringWheel = new SteeringWheel();
Console.WriteLine($"Currently going in direction: {steeringWheel.Steering}");
steeringWheel.TurnLeft();
Console.WriteLine($"Currently going in direction: {steeringWheel.Steering}");
steeringWheel.TurnRight();
Console.WriteLine($"Currently going in direction: {steeringWheel.Steering}");
steeringWheel.TurnRight();
Console.WriteLine($"Currently going in direction: {steeringWheel.Steering}");
steeringWheel.TurnLeft();
Console.WriteLine($"Currently going in direction: {steeringWheel.Steering}");





//// Abstract class - fruit demo
//Person person = new Person();
//Fruit fruit1 = new Mango();
//Fruit fruit2 = new Lemon();
//person.Eat(fruit1);
//person.Eat(fruit2);
