using System;
using System.Collections.Generic;
using OOOtherDemo;

//// Lists
//string[]     myArray  = new string[3];
//List<string> myList   = new List<string>();

//myArray[0] = "aaa";
//myList.Add("aaa");

//Console.WriteLine($"array: {myArray[0]}");
//Console.WriteLine($"list : {myList[0]}");

//myList.Insert(0, "bbb"); // listan innehåller: "bbb", "aaa"
//myList.Add("ccc"); // listan innehåller: "bbb", "aaa", "ccc"

//myList.AddRange(new string[] { "ddd", "eee" }); // listan innehåller: "bbb", "aaa", "ccc", "ddd", "eee"
//List<string> myList2 = new List<string>();
//myList2.Add("fff");
//myList2.Add("ggg");
//myList.AddRange(myList2); // listan innehåller: "bbb", "aaa", "ccc", "ddd", "eee", "fff", "ggg"

//myList.Remove("ccc"); // listan innehåller: "bbb", "aaa", "ddd", "eee", "fff", "ggg"
//myList.RemoveAt(1); // listan innehåller: "bbb", "ddd", "eee", "fff", "ggg"
//myList.RemoveRange(0, 3); // listan innehåller: "fff", "ggg"

//foreach (string item in myList)
//{
//    Console.WriteLine($"List item: {item}");
//}

// Static

StaticDemo._myStaticField = "aa";
StaticDemo.MyStaticProperty = "bb";
StaticDemo.MyStaticMetod();

Console.WriteLine("hej");
Convert.ToInt32("1");
