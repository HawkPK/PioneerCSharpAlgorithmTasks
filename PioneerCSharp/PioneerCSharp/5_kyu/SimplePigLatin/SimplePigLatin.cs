using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace PioneerCSharp._5_kyu.SimplePigLatin
{
    public static class SimplePigLatin
    {
        public const string lastLetters = "ay";
        public static string PigIt(string str)
        {
            string[] arr = str.Split(' ');
            var newWord = "";

            for (int i = 0; i < arr.Length; i++)
            {
                var otherLetters = arr[i].Substring(1);
                var firstLetter = arr[i].Substring(0, 1);
                if (Regex.Match(firstLetter, @"[a-zA-Z]").Success)
                {
                    newWord += otherLetters + firstLetter + lastLetters;
                } else
                {
                    newWord += firstLetter;
                }

                if (i != arr.Length - 1)
                {
                    newWord += " ";
                }
            }
            return newWord;
        }
    }
}
