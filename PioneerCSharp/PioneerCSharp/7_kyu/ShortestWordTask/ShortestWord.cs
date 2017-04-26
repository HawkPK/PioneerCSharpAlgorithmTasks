using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PioneerCSharp._7_kyu.ShortestWord
{
    public class ShortestWord
    {
        public static int Compute(string statements)
        {
            String[] arr = statements.Split(' ');
            int longestWord = int.MaxValue;

            foreach(string word in arr)
            {
                longestWord = Math.Min(longestWord, word.Length);
            }

            return longestWord;
        }

        public static int ComputeTuning(string statements)
        {
            return statements.Split(' ').Min(s => s.Length);
        }
    }
}
