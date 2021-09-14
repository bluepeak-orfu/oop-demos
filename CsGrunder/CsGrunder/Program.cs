using System;
using System.Globalization;


namespace CsGrunder
{
    class Program
    {
        static void Main(string[] args)
        {
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



            //// Ett "block" skapas med måsvingar
            //// Variabler i ett block går inte att komma åt utanför blocket
            //{
            //    int x = 5;
            //    Console.WriteLine(x);
            //}
            ////Console.WriteLine(x); // <-- här kommer vi inte åt x.

            int age = 18;
            if (age < 18)
                Console.WriteLine("Yngre än 18");
                Console.WriteLine("Yngre än 18"); // <-- inte del av if:en

            if (age < 18)
            {
                Console.WriteLine("Yngre än 18");
                Console.WriteLine("Yngre än 18");
                Console.WriteLine("Yngre än 18");
            }

            bool x1 = age == 18;
            bool x2 = age != 18;
            bool x3 = age < 18;
            bool x4 = age <= 18;
            bool x5 = age >= 18;

            bool x6 = x1 && x2; // <-- OCH
            bool x7 = x1 || x2; // <-- ELLER
            bool x8 = x1 && x2 || x3;
            bool x9 = x1 && (x2 || x3);

            bool x10 = !x1; // true blir false, false blir true
        }
    }
}
