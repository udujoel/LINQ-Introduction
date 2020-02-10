using System;
using System.IO;

namespace LINQ_Introduction
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"c:\windows";
            ShowLargeFIlesWithoutLINQ(path);
        }

        private static void ShowLargeFIlesWithoutLINQ(string path)
        {
            DirectoryInfo directory = new DirectoryInfo(path);
            var files = directory.GetFiles();

            foreach (var file in files)
            {
                Console.WriteLine($"{file.Name} ==> {file.Length}");
            }

        }
    }
}
