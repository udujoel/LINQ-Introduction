using System;
using System.Collections.Generic;
using System.IO;

using Console_Output_Formatter;

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
            Array.Sort(files, new FileComparer());

            for (var count = 0; count < 5; count++)
            {
                var file = files[count];
                //                Console.WriteLine($"{file.Name,20} \t\t==>\t\t {file.Length,10:N1}");
                Formatter.ColoredMessage($"{files[count].Name,20} \t\t==>\t\t {files[count].Length,10:N1}");
            }
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
