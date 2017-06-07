/*
Source: https://www.codewars.com/kata/credit-card-mask

Usually when you buy something, you're asked whether your credit card number, phone number or answer to your most secret question is still correct. However, since someone could look over your shoulder, you don't want that shown on your screen.Instead, we mask it.

Your task is to write a function maskify, which changes all but the last four characters into '#'.

Examples

Kata.Maskify('4556364607935616'); // should return "############5616"
Kata.Maskify('64607935616');      // should return "#######5616"
Kata.Maskify('1');                // should return "1"
Kata.Maskify('');                 // should return ""

// "What was the name of your first pet?"
Kata.Maskify('Skippy');                                   // should return "##ippy"
Kata.Maskify('Nananananananananananananananana Batman!'); // should return "####################################man!"
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PioneerCSharp._7_kyu
{
    public class CreditMask
    {
        private static string finalResult;
        private static string markHash = "#";

        public static string Maskify(string text)
        {
            finalResult = "";
            if (text.Length < 5)
            {
                return text;
            } else
            {
                char[] arr = text.ToCharArray();
                var buffor = arr.Length - 4;

                for(int i = 0; i < buffor; i++)
                {
                    finalResult += markHash;
                }

                finalResult += text.Substring(buffor);
                return finalResult;
            }
        }
    }
}
