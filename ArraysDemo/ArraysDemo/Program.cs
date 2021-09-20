using System;

int[] myIntArray;
int[] myIntArray2 = new int[8];
myIntArray2 = new int[4];

myIntArray2[2] = 5;
myIntArray2[0] = 1; //0-indexerat

int myInt = myIntArray2[2];
int myInt2 = myIntArray2[1];

Console.WriteLine($"myInt: {myInt}");
Console.WriteLine($"myInt2: {myInt2}");

Console.WriteLine($"myIntArray längd: {myIntArray2.Length}");

// Console.WriteLine($"Out of bounds: {myIntArray2[4]}"); // crashes the program

for (int i = 0; i < myIntArray2.Length; i++)
{
    Console.WriteLine($"Array content at position {i}: {myIntArray2[i]}");
}

// Special C# syntax
int myInt3 = myIntArray2[myIntArray2.Length - 1];
int myInt4 = myIntArray2[^1];

int[] myIntArray3 = myIntArray2[0..2];
Console.WriteLine($"myIntArray3.Length: {myIntArray3.Length}");

myIntArray3 = myIntArray2[2..];
myIntArray3 = myIntArray2[..2];
myIntArray3 = myIntArray2[2..^1];


// Init arrays
int[] myIntArray4 = new int[3] { 5, 6, 7 };
for (int i = 0; i < myIntArray4.Length; i++)
{
    Console.WriteLine($"myIntArray4 content at position {i}: {myIntArray4[i]}");
}

myIntArray4 = new int[] { 5, 6, 7 };
myIntArray4 = new [] { 5, 6, 7 };
// var myIntArray5 = new [] { "abc", 6, 7.0 }; // Cannot mix data types


foreach (int myIntValue in myIntArray2)
{
    Console.WriteLine($"foreach: {myIntValue}");
}


int[][] myTwoDimArray = new int[3][];
myTwoDimArray[0] = new int[1];
myTwoDimArray[1] = new int[3];
myTwoDimArray[2] = new int[5];

myTwoDimArray[1][1] = 13;
Console.WriteLine($"myTwoDimArray[1][1]: {myTwoDimArray[1][1]}");

int[,] myTwoDimArray2 = new int[3, 2];
myTwoDimArray2[1, 1] = 15;
Console.WriteLine($"myTwoDimArray2[1, 1]: {myTwoDimArray2[1, 1]}");

int[,] myTwoDimArray3 = new[,] { { 2, 3 } };
Console.WriteLine($"myTwoDimArray3: {myTwoDimArray3[0, 0]} | {myTwoDimArray3[0, 1]}");

int[,] myTwoDimArray4 = new[,] { { 2, 3, 4 }, { 5, 6, 7 } };
