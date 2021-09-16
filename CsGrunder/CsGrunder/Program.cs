using System;
using System.Globalization;

//// Deklarera variabler
//// Add deklarera en variable "paxar" plats i minnet för den variabeln
//int y;
//// Vi kan deklarera och tilldela en variabel på samma rad
//int x = 5;
//// Vi kan ha olika datatyper
//uint x2 = 5;

//string myString = "abc";

//// Med "var" får variabeln den typ som värdet till höger om likamedtecknet
//var myVar = 5.0;
//// Vi kan inte deklarera en variabel med "var" utan att tilldela ett värde
////var myVar2;

//var myVar3 = 2.0m;

//// Vi kan öka läsbarheten av stora värden genom att lägga till "_"
//int myVar4 = 1_000_000;
//double myVar5 = 1_0___0__0_00__________0.0;

//// Vi kan tvinga ett värde att bli en viss typ
//float myFloat = 2.0F;

//// Vi kan ange värden i 2-bas
//int myBinaryInt = 0b00001100;
//Console.WriteLine(myBinaryInt);

//// Vi kan ange värden i 16-bas
//int myHexInt = 0x7B;



//// Matte
//Console.WriteLine(2 + 3);

//int x = 4 * 3;
//Console.WriteLine(x);

//Console.WriteLine(2 + 3 * 4);
//Console.WriteLine((2 + 3) * 4);

//// Modulus (%) ger oss resten efter division
//Console.WriteLine(3 % 2);
//Console.WriteLine(5 % 3);

//// Componet assigmnent
//int x = 1;
//x = x + 2;
//x += 2;
//Console.WriteLine(x);

//double y = 1.2;
//y /= 0.1;
//Console.WriteLine(y);

//int x = 1;
//Console.WriteLine(x++);
//Console.WriteLine(++x);

//Console.WriteLine(x--);
//Console.WriteLine(--x);



//// Type casting
//Console.WriteLine(3 / 2);

//long x = 1;
//int y = (int)1L;
//Console.WriteLine(y);
//long y3 = 21474836479;
//int y2 = (int)y3;
//Console.WriteLine(y2);

//float x = 1.9f;
//int y = (int)x;
//Console.WriteLine(y);

//int x = 0;
//Console.WriteLine(5 / x); // int-division med 0 ger fel

//Console.WriteLine(5.0 / 0.0); // flyttal-division med 0 ger oändligheten

//// Notera vilken typ e-variablerna får när vi adderar
//// olika typer
//var e = 1 + 1L;
//var e2 = 1.0 + 1;
//var e3 = 3 / 2.0;
//int myValue = 123;
//var e4 = myValue / 2.0;
//var e5 = "String" + 2;
//var e6 = "String " + (10 + 20);


//// Overflow
//Console.WriteLine(int.MaxValue);
//Console.WriteLine(long.MaxValue);

//int x = 1;
//Console.WriteLine(int.MaxValue + x);

//uint x2 = 1;
//Console.WriteLine(uint.MaxValue + x2);


//// Convert strings
//Console.WriteLine(Convert.ToInt32("123"));
//Console.WriteLine(Convert.ToDouble("12,3"));
//Console.WriteLine(Convert.ToDouble("12.3", CultureInfo.GetCultureInfo("en-US")));

//Console.WriteLine(int.Parse("123"));
//Console.WriteLine(double.Parse("123,45"));


//// Building strings
//// Hur skriver vi specialtecken i strängar?
//string x = "abc \"hej\" \\";
//Console.WriteLine(x);
//Console.WriteLine("a\tb\nc");

//// Vi kan addera strängar men det kan bli svårläst
//string x2 = "hej " + "då";

//string myStr = "hej";
//int myInt = 123;
//double myDouble = 12.34;

//// String composition
//Console.WriteLine("{0} {1}", myStr, myInt);
//Console.WriteLine("{1} {0} {0} {0}", myStr, myInt);

//// String interpolation
//Console.WriteLine($"{myStr} {myInt}");
//Console.WriteLine($"{myInt} {myStr} {myStr} {myStr}");

//// String justify & format
//Console.WriteLine("{0,10}", myInt);
//Console.WriteLine("{0,-10}", myInt);

//Console.WriteLine("{0,-10} {1, 5}", 12, 12.34);
//Console.WriteLine("{0,-10} {1, 5}", 120, 123.34);
//Console.WriteLine("{0,-10} {1, 5}", 547, 1992.1);
//Console.WriteLine("{0,-10} {1, 5}", 547_123_123_12, 1992.1);

//Console.WriteLine("{0:N1} {1:C}", 12, 12.34);

//Console.WriteLine("{0,10:N1}", 12);
//Console.WriteLine("{0,10:N1}", 1234);
//Console.WriteLine("{0,10:N1}", 123456);

//string myFormattedString = string.Format(CultureInfo.GetCultureInfo("en-US"), "{0:C}", 34.21);
//Console.WriteLine("myFormattedString: " + myFormattedString);

//double myFormatableDouble = 2344.432;
//Console.WriteLine(myFormatableDouble.ToString("F1"));

//Console.WriteLine($"{myStr,10} {myInt,-10}");
