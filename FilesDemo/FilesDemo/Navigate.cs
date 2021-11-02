using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FilesDemo
{
    class Navigate
    {
        public void Demo()
        {
            string fileName = "../testfile1.txt";
            string absolutPath = "c:/repos/blabal/testfile1.txt";

            string correctFileNamePath = Path.Join("..", "testfile1.txt");
            Console.WriteLine($"correctFileNamePath: {correctFileNamePath}");

            string absolutePath = Path.GetFullPath(correctFileNamePath);
            Console.WriteLine($"absolutePath: {absolutePath}");

            string[] files = Directory.GetFiles(".");
            string[] dirs = Directory.GetDirectories(".");
            string[] entries = Directory.GetFileSystemEntries(".");
        }
    }
}
