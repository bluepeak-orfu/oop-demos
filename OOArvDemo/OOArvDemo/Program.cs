using System;
using OOArvDemo;

ChildClass cc = new ChildClass();
cc.MyMethod();

ChildClass cc2 = new ChildClass(6);

//Console.WriteLine($"Utifrån Private: {cc2._privateField}");
//Console.WriteLine($"Utifrån Protected: {cc2._protectedField}");
Console.WriteLine($"Utifrån Public: {cc2._publicField}");

cc2.AccessDemoParent();
cc2.AccessDemoChild();

//ParentClass child1;
//child1 = new ChildClass();

//int myInt2 = 4;
//long myLong2 = myInt2;


ParentClass child1 = new ChildClass();
ChildClass child2 = new ChildClass();
child1.AccessDemoParent();
// child1.AccessDemoChild(); // Vi kommer inte åt den

child2.AccessDemoParent();
child2.AccessDemoChild(); // Vi kommer åt den


long myLong = 1;
int myInt = (int)myLong;

ChildClass child3 = (ChildClass)child1;
child3.AccessDemoParent();
child3.AccessDemoChild(); // Vi kommer åt den

ParentClass child4 = new ParentClass(8);
//ChildClass child5 = (ChildClass)child4; // Kraschar


if (child4.GetType() == typeof(ChildClass))
{
    Console.WriteLine("Är av typen ChildClass");
}
else
{
    Console.WriteLine($"Är inte av typen ChildClass. Är en {child4.GetType()}");
}


ChildClass child6 = child4 as ChildClass;
if (child6 == null)
{
    Console.WriteLine("child4 as ChildClass gives null");
}

ChildClass child7 = child1 as ChildClass;
if (child7 != null)
{
    Console.WriteLine("child1 as ChildClass is valid");
}



if (child4 is ChildClass child8)
{
    Console.WriteLine("child4 is a ChildClass instance");
}
else
{
    Console.WriteLine("child4 is not a ChildClass instance");
}

if (child1 is ChildClass child9)
{
    Console.WriteLine("child1 is a ChildClass instance");
    child9.AccessDemoChild();
}
else
{
    Console.WriteLine("child1 is not a ChildClass instance");
}

