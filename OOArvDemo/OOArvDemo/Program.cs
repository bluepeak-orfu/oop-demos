using System;
using OOArvDemo;

//ChildClass cc = new ChildClass();
//cc.MyMethod();

//ChildClass cc2 = new ChildClass(6);

////Console.WriteLine($"Utifrån Private: {cc2._privateField}");
////Console.WriteLine($"Utifrån Protected: {cc2._protectedField}");
//Console.WriteLine($"Utifrån Public: {cc2._publicField}");

//cc2.AccessDemoParent();
//cc2.AccessDemoChild();

//ParentClass child1;
//child1 = new ChildClass();

//int myInt2 = 4;
//long myLong2 = myInt2;


//ParentClass child1 = new ChildClass();
//ChildClass child2 = new ChildClass();
//child1.AccessDemoParent();
//// child1.AccessDemoChild(); // Vi kommer inte åt den

//child2.AccessDemoParent();
//child2.AccessDemoChild(); // Vi kommer åt den


//long myLong = 1;
//int myInt = (int)myLong;

//ChildClass child3 = (ChildClass)child1;
//child3.AccessDemoParent();
//child3.AccessDemoChild(); // Vi kommer åt den

//ParentClass child4 = new ParentClass(8);
////ChildClass child5 = (ChildClass)child4; // Kraschar


//if (child4.GetType() == typeof(ChildClass))
//{
//    Console.WriteLine("Är av typen ChildClass");
//}
//else
//{
//    Console.WriteLine($"Är inte av typen ChildClass. Är en {child4.GetType()}");
//}


//ChildClass child6 = child4 as ChildClass;
//if (child6 == null)
//{
//    Console.WriteLine("child4 as ChildClass gives null");
//}

//ChildClass child7 = child1 as ChildClass;
//if (child7 != null)
//{
//    Console.WriteLine("child1 as ChildClass is valid");
//}



//if (child4 is ChildClass child8)
//{
//    Console.WriteLine("child4 is a ChildClass instance");
//}
//else
//{
//    Console.WriteLine("child4 is not a ChildClass instance");
//}

//if (child1 is ChildClass child9)
//{
//    Console.WriteLine("child1 is a ChildClass instance");
//    child9.AccessDemoChild();
//}
//else
//{
//    Console.WriteLine("child1 is not a ChildClass instance");
//}

//Car car1 = new Car();
//car1.Start();
//Console.WriteLine($"Car1 is running: {car1.IsRunning}");
//Console.WriteLine();

//Car car2 = new ElectricCar();
//car2.Start();
//// car2.ConnectToCharger();
//Console.WriteLine($"Car2 is running: {car2.IsRunning}");
//Console.WriteLine();

//ElectricCar electricCar1 = new ElectricCar();
//electricCar1.Start();
////electricCar1.ConnectToCharger();
//Console.WriteLine($"electricCar1 is running: {electricCar1.IsRunning}");
//Console.WriteLine();

//ElectricCar electricCar2 = (ElectricCar)car2;
//electricCar2.Start();
//electricCar2.ConnectToCharger();

//if (car2 is ElectricCar electricCar3)
//{
//    electricCar3.Start();
//    electricCar3.ConnectToCharger();
//}

////Vehicle v1 = new Vehicle();
//Vehicle v2 = new Car();
//Console.WriteLine($"v2 wheels: {v2.NumberOfWheels}");
//v2.TurnLeft();
//Console.WriteLine();

//Vehicle v3 = new Motorcycle();
//Console.WriteLine($"v3 wheels: {v3.NumberOfWheels}");
//v3.TurnLeft();
//Console.WriteLine();

//Vehicle v4 = new ElectricCar();
//Console.WriteLine($"v4 wheels: {v4.NumberOfWheels}");
//v4.TurnLeft();
//Console.WriteLine();

//object o1 = new Car()
//{
//    RegNumber = "ABC123",
//    Color = "Red"
//};
//object o2 = new Car()
//{
//    RegNumber = "ABC123",
//    Color = "Green"
//};
//Console.WriteLine($"o1: {o1}");
//Console.WriteLine($"o2: {o2}");

//if (o1 == o2)
//{
//    Console.WriteLine("Car 1 and car 2 are the same");
//}

//if (o1.Equals(o2))
//{
//    Console.WriteLine("Car 1 and car 2 are equal");
//}

ICanBreak car1 = new Car();
car1.Break();

ICanBreak2 car2 = new Car();
car2.Break();
