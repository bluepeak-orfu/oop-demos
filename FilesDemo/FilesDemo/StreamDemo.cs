using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FilesDemo
{
    class StreamDemo
    {
        public void ReadFromStream()
        {
            FileStream fs = File.OpenRead("demo4.txt");
            StreamReader sr = new StreamReader(fs);
            try
            {
                Console.WriteLine($"Line: {sr.ReadLine()}");
                Console.WriteLine($"Line: {sr.ReadLine()}");
            }
            finally
            {
                sr.Close();
            }
            Console.ReadKey();
        }

        public void ReadFromStreamWithUsing()
        {
            FileStream fs = File.OpenRead("demo4.txt");
            using(StreamReader sr = new StreamReader(fs))
            {
                Console.WriteLine($"Line: {sr.ReadLine()}");
                Console.WriteLine($"Line: {sr.ReadLine()}");
            }
            Console.ReadKey();
        }

        public void PrintAllContent()
        {
            FileStream fs = File.OpenRead("demo4.txt");
            using (StreamReader sr = new StreamReader(fs))
            {
                while (true)
                {
                    string line = sr.ReadLine();
                    if (line == null)
                    {
                        break;
                    }
                    Console.WriteLine($"Line 1: {line}");
                }
            }

            // Exempel där vi använder kompakt syntax för att läsa lines
            FileStream fs2 = File.OpenRead("demo4.txt");
            using (StreamReader sr = new StreamReader(fs2))
            {
                string line;
                while ((line = sr.ReadLine()) != null)
                {
                    Console.WriteLine($"Line 2: {line}");
                }
            }

            FileStream fs3 = File.OpenRead("demo4.txt");
            using (StreamReader sr = new StreamReader(fs3))
            {
                while (!sr.EndOfStream)
                {
                    string line = sr.ReadLine();
                    Console.WriteLine($"Line 3: {line}");
                }
            }
        }

        public void WriteContent(string[] contents)
        {
            FileStream fs = File.Create("demo6.txt");
            using (StreamWriter sw = new StreamWriter(fs))
            {
                foreach (string content in contents)
                {
                    sw.WriteLine(content);
                }
            }
        }
    }
}
