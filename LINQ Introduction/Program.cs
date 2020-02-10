using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

using static Console_Output_Formatter.Formatter;

namespace LINQ_Introduction
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"c:\windows";
            ShowLargeFIlesWithoutLINQ(path);
            ShowLargeFIlesWithLINQ(path);
        }

        private static void ShowLargeFIlesWithoutLINQ(string path)
        {
            DirectoryInfo directory = new DirectoryInfo(path);
            var files = directory.GetFiles();
            Array.Sort(files, new FileComparer());

            for (var count = 0; count < 5; count++)
            {
                var file = files[count];
                //                Console.WriteLine($"{file.Name,20} \t\t==>\t\t {file.Length,10:N1}");
                ColoredMessage($"{files[count].Name,20} \t\t==>\t\t {files[count].Length,10:N0}");




            }

            ColoredMessage("___________________");
        }

        private static void ShowLargeFIlesWithLINQ(string path)
        {
            var query = from Files in new DirectoryInfo(path).GetFiles()
                        orderby Files.Length descending
                        select Files;

            foreach (var files in query.Take(5))
            {
                ColoredMessage($"{files.Name,20} \t\t==>\t\t {files.Length,10:N0}");

            }

            Console.ReadKey();
        }

        public class FileComparer : IComparer<FileInfo>
        {
            public int Compare(FileInfo x, FileInfo y)
            {
                return y.Length.CompareTo(x.Length);
            }
        }
    }
}
