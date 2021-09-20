using System;

//Console.WriteLine("Hej då");

//// Skriv text till console:en utan att byta till ny rad
//Console.Write("Hej");
//Console.Write(" då");
//Console.WriteLine();

//// Vi kan läsa bara 1 bokstav eller 1 "tecken"
//var input = Console.Read();
//Console.WriteLine($"input: {input}");
//var inputKey = Console.ReadKey();
//Console.WriteLine($"inputKey: {inputKey.KeyChar}");

//// Exempel där vi använder ReadKey
//Console.Write("y/n?");
//ConsoleKeyInfo inputKey2 = Console.ReadKey(true);
//Console.WriteLine();

//// Utför olika operationer beroende på vilken bokstav användaren tryckte på
//switch (inputKey2.Key)
//{
//    case ConsoleKey.Y:
//        Console.WriteLine("User answered yes");
//        break;
//    case ConsoleKey.N:
//        Console.WriteLine("User answered no");
//        break;
//    default:
//        Console.WriteLine("Unknown answer");
//        break;
//}

//// Samma som switchen innan men kollar på char istället för ConsoleKey
//switch (inputKey2.KeyChar)
//{
//    case 'y':
//        Console.WriteLine("User answered yes");
//        break;
//    case 'n':
//        Console.WriteLine("User answered no");
//        break;
//    default:
//        Console.WriteLine("Unknown answer");
//        break;
//}

//// Läser ett tecken utan att skriva ut det
//ConsoleKeyInfo inputKey3 = Console.ReadKey(true);
//Console.WriteLine($"inputKey2.Key {inputKey3.Key}");
//Console.WriteLine($"inputKey2.KeyChar {inputKey3.KeyChar}");

//// Vi kan rensa console:en på allt innehåll
//Console.WriteLine("Hej");
//Console.Clear();
//Console.WriteLine("Hello");

//// Vi kan ange hur stor console-fönstret ska vara
//Console.SetWindowSize(100, 10);
//Console.SetBufferSize(100, 10);

//// Exempel på där vi använder Clear för att skriva en "program-loop"
//while (true)
//{
//    Console.Clear();
//    Console.WriteLine("What is your name?");
//    string input = Console.ReadLine();

//    Console.WriteLine($"Hello {input}");

//    Console.ReadKey();
//}

//// Vi kan ändra text- och bakgrundsfärg i console:en
//Console.WriteLine("Hej");
//Console.BackgroundColor = ConsoleColor.Green;
//Console.WriteLine(" då");

//Console.BackgroundColor = ConsoleColor.Green;
//Console.Clear();
//Console.ReadKey();

//Console.WriteLine("Hej");
//Console.ForegroundColor = ConsoleColor.Red;
//Console.WriteLine(" då");

//// Vi kan också återställa färgerna till deras standardvärden
//Console.ResetColor();
//Console.Clear();
//Console.ReadKey();
