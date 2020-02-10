using System;
using System.Collections.Generic;
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
            Array.Sort(files, new FileComparer());

            foreach (var file in files)
            {
                Console.WriteLine($"{file.Name} \t\t==>\t\t {file.Length}");
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
