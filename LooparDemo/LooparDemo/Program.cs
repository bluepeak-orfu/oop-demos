using System;

//// Att manuellt skriva ut saker som upprepar sig är jobbigt
//Console.WriteLine(1);
//Console.WriteLine(2);
//Console.WriteLine(3);
//Console.WriteLine(4);
//Console.WriteLine(5);
//Console.WriteLine(6);
//Console.WriteLine(7);
//Console.WriteLine(8);
//Console.WriteLine(9);
//Console.WriteLine(10);



//// Använd loopar för att kör en bit kod flera gånger
//for (var i = 1; i <= 10000; i++)
//{
//    if (i % 5 == 0)
//    {
//        Console.WriteLine(i);
//    }
//}



//// while är en annan typ av loop
//int i = 0;
//while (i < 1000)
//{
//    i++;
//    if (i == 10)
//    {
//        continue;
//    }
//    Console.WriteLine("Nu snurrar vi på " + i);

//    if (i == 50)
//    {
//        Console.WriteLine("Vi avslutade eftersom vi hamnade på 50.");
//        break;
//    }
//}

//// Use break to exit forever running loop.
//// Can be used as main program loop to keep program
//// running indefinitely until user wants to exit.
//while (true)
//{
//    string input = Console.ReadLine();

//    if (input == "")
//    {
//        break;
//    }

//    Console.WriteLine($"Input was: {input}");
//}

//// Do-while loop
//string input;
//do
//{
//    input = Console.ReadLine();

//    Console.WriteLine($"Input was: {input}");
//} while (input != "");
