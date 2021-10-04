using System;
using MinneshanteringDemo;

int x1 = 5;
int x2 = x1;

Console.WriteLine($"x1: {x1}");
Console.WriteLine($"x2: {x2}");

x1 = 11;

Console.WriteLine($"x1: {x1}");
Console.WriteLine($"x2: {x2}");


//MyClass m1 = new MyClass() { MyValue = 5 };
//MyClass m2 = m1;

//Console.WriteLine($"m1: {m1.MyValue}");
//Console.WriteLine($"m2: {m2.MyValue}");

//m1.MyValue = 11;

//Console.WriteLine($"m1: {m1.MyValue}");
//Console.WriteLine($"m2: {m2.MyValue}");


//MyClass m3 = new MyClass() { MyValue = 22 };
//MyClass m4 = new MyClass() { MyValue = 22 };

//if (m3 == m4)
//{
//    Console.WriteLine("m3 is equal to m4");
//}
//else
//{
//    Console.WriteLine("m3 is not equal to m4");
//}

//if (m1 == m2)
//{
//    Console.WriteLine("m1 is equal to m2");
//}
//else
//{
//    Console.WriteLine("m1 is not equal to m2");
//}


// Null

string s = null;
int[] ii = null;
MyClass mc = null;
// int x = null; // bara referenstyper kan vara null

//string s2 = null;
//if (Console.ReadLine() == "y")
//{
//    s2 = "yes";
//}
//else
//{
//    s2 = "no";
//}

//Console.WriteLine($"{s.Length}"); // Kraschar programmet

//if (s != null)
//{
//    Console.WriteLine($"{s.Length}");
//}

//if (s == null)
//{
//    Console.WriteLine("Variable s is null");
//}


string s2 = "abc";
Console.WriteLine($"Length of s: {s?.Length}");
Console.WriteLine($"Length of s: {s2?.Length}");

string result = s ?? "hej";
Console.WriteLine($"Result: {result}");

MyClass m1 = null;
int theValue = m1?.MyValue ?? 0;
Console.WriteLine($"theValue: {theValue}");
