using OOGrunderDemo;
using System;

Car car1 = new Car("Volvo", "ABC123");
//Console.ReadLine();
//Car car2 = new Car();
//Console.ReadLine();

var carX = new Car();
Car carY = new();
Car carY2 = new("Saab", "BBB222");

car1.Repaint("Yellow");
bool x = car1.NeedService();
Console.WriteLine($"Need service 1: {x}");
car1.IncreaseAge();
car1.IncreaseAge();
car1.IncreaseAge();
car1.IncreaseAge();
car1.IncreaseAge();
car1.IncreaseAge();
bool x2 = car1.NeedService();
Console.WriteLine($"Need service 2: {x2}");

car1.DisplayName("PRE", "POST");
car1.DisplayName("", "POST");

//Car car3 = new Car();
//string brand3 = Console.ReadLine();
//string regNumber3 = Console.ReadLine();
