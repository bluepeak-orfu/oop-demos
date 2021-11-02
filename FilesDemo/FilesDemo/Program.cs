using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace FilesDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            //string fileContent = File.ReadAllText("demo1.txt");
            //Console.WriteLine($"Content is: {fileContent}");

            ////// Ingen bra idé att skriva ut icke textfiler
            ////string fileContent = File.ReadAllText("FilesDemo.exe");
            ////Console.WriteLine($"Content is: {fileContent}");

            //// Skriver över filen om den finns
            //File.WriteAllText("demo2.txt", "Text from C#");

            //// Lägger till i slutet på filen. Skapar om den inte finns
            //File.AppendAllText("demo2.txt", "More text in the file");

            //string fileName = "demo3.txt";
            //if (!File.Exists(fileName))
            //{
            //    File.WriteAllText(fileName, "Header1\tHeader2\n");
            //}
            //else
            //{
            //    File.AppendAllText(fileName, "Data1\tData2\n");
            //}

            //string[] lines = File.ReadAllLines("demo4.txt");
            //foreach (string line in lines)
            //{
            //    Console.WriteLine($"Line content: {line}");
            //}
            ////string[] lines = File.ReadAllText("demo4.txt").Split("\n");

            //List<string> inputs = new List<string>();
            //while (true)
            //{
            //    Console.WriteLine("Write some input");
            //    string input = Console.ReadLine();
            //    if (input == "")
            //    {
            //        break;
            //    }
            //    inputs.Add(input);
            //}
            //File.WriteAllLines("demo5.txt", inputs);

            StreamDemo demo = new StreamDemo();
            //demo.ReadFromStream();
            //demo.ReadFromStreamWithUsing();
            //demo.PrintAllContent();
            //demo.WriteContent(new string[] { "QQQQ", "WWWW", "EEEE" });

            Navigate nav = new Navigate();
            nav.Demo();
        }
    }
}
