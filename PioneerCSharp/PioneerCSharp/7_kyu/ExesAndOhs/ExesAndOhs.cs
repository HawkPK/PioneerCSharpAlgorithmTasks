using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PioneerCSharp._7_kyu.Exes_and_Ohs
{
    public class ExesAndOhs
    {
        public static bool Compute(string word)
        {
            char[] arr = word.ToCharArray();
            int counterX = 0;
            int counterO = 0;
            foreach (char item in arr)
            {
                if(Char.ToUpper(item) == 'O')
                {
                    counterO++;
                } else if (Char.ToUpper(item) == 'X')
                {
                    counterX++;
                }
            }

            return counterO == counterX ? true : false;
        }

        public static bool ComputeRef(string word)
        {
            return word.ToUpper().Count(c => c == 'X') == word.ToUpper().Count(c => c == 'O');
        }
    }
}
