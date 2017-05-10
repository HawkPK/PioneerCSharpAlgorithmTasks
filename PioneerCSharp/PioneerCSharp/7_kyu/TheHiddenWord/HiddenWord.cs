using System;
using System.Collections.Generic;

namespace PioneerCSharp._7_kyu.TheHiddenWord
{
    public class HiddenWord
    {
        public static string Hide(int number)
        {
            Char[] array = number.ToString().ToCharArray();
            string result = "";
            foreach (char item in array)
            {
                result = (result + ReturnLetter(item));
            }
            return result;
        }

        private static string ReturnLetter(char letter)
        {
            Dictionary<int, string> dict = new Dictionary<int, string>();
            dict.Add(6,"a");
            dict.Add(1,"b");
            dict.Add(7,"d");
            dict.Add(4,"e");
            dict.Add(3,"i");
            dict.Add(2,"l");
            dict.Add(9,"m");
            dict.Add(8,"n");
            dict.Add(0,"o");
            dict.Add(5,"t");

            return dict[(int) Char.GetNumericValue(letter)];
        }
    }
}