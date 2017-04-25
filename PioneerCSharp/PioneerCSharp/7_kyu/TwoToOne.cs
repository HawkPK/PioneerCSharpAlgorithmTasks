using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PioneerCSharp._7_kyu
{
    public class TwoToOne
    {

        public static string sortLetter(string firstWord, string secondWord)
        {
            string word = firstWord + secondWord;
            string finalResult = "";
            char[] splitWord = word.ToCharArray().Select(s => s).OrderBy(s => s).Distinct().ToArray();

            foreach (char elem in splitWord)
            {
                finalResult = finalResult + elem.ToString();
            }
            
            return finalResult;
        }
    }
}
