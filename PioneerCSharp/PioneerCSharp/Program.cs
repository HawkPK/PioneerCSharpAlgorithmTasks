using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PioneerCSharp.LINQ;

namespace PioneerCSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            Content content = new Content();
            content.FindTheFiveLargerFiles();
            content.FindTheFiveLargerFilesWithLinq();
        }
    }
}
