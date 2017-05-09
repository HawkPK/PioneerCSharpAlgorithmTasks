using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PioneerCSharp.LINQ
{
    public class Content
    {
        private string _path;



        public void FindTheFiveLargerFiles()
        {
            _path = @"C:\windows";
            DirectoryInfo dir = new DirectoryInfo(_path);
            FileInfo[] fileInfo = dir.GetFiles();
            Array.Sort(fileInfo, new ComparerSize());

            for(int i = 0; i < 5; i++)
            {
                Console.WriteLine($"{fileInfo[i].Name, -20} : {fileInfo[i].Length, 10:N0}");

            }

            Console.ReadKey();
            Console.WriteLine("#############");


        }

        public void FindTheFiveLargerFilesWithLinq()
        {
            _path = @"C:\windows";
            var query = from file in new DirectoryInfo(_path).GetFiles()
                        orderby file.Length descending 
                        select file;

            foreach (FileInfo fileInfo in query.Take(5))
            {
                Console.WriteLine($"{fileInfo.Name,-20} : {fileInfo.Length,10:N0}");
            }

            Console.ReadKey();
            Console.WriteLine("#############");


            var queryAlternative = new DirectoryInfo(_path).GetFiles()
                        .OrderByDescending(f => f.Length).Take(5);
            foreach (FileInfo fileInfo in queryAlternative)
            {
                Console.WriteLine($"{fileInfo.Name,-20} : {fileInfo.Length,10:N0}");
            }

            Console.ReadKey();
        }
    }

    public class ComparerSize : IComparer<FileInfo>
    {
        public int Compare(FileInfo x, FileInfo y)
        {
            return y.Length.CompareTo(x.Length);
        }
    }
}

