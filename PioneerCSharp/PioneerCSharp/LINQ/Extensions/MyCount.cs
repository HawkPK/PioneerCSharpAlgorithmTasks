using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PioneerCSharp.LINQ.Extensions.NewLinq
{
    public static class MyCount
    {
        public static int Count<T>(this IEnumerable<T> sequence)
        {
            int count = 0;
            foreach (var elem in sequence)
            {
                count++;
            }
            return count;
        }
    }
}
