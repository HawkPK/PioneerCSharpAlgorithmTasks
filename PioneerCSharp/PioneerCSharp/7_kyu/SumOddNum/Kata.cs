﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Given the triangle of consecutive odd numbers:

//             1
//          3     5
//       7     9    11
//   13    15    17    19
//21    23    25    27    29
//...
//Calculate the row sums of this triangle from the row index (starting at index 1) e.g.:

//rowSumOddNumbers(1); // 1
//rowSumOddNumbers(2); // 3 + 5 = 8

namespace PioneerCSharp._7_kyu.SumOddNum
{
    public class Kata
    {
        private static long result = 0;
        private static long baza = 0;


        public static long rowSumOddNumberBasis(long v)
        {
            result = 0;
            baza = 1;
            for(int i = 2; i < v; i++)
            {
                for(int j = 0; j < i; j++)
                {
                        baza += 2;
                }
            }

            result = 0;
            baza += 2;

            for(int i = 0; i < v; i++)
            {
                result += (baza);
                baza += 2;
            }


            return result;
        }


        public static long rowSumOddNumberBasisRef(long v)
        {
            result = 0;
            baza = BaseNumberToStartCompute(v);

            for (int i = 0; i < v; i++)
            {
                result += (baza);
                baza += 2;
            }

            return result;
        }

        private static long BaseNumberToStartCompute(long v)
        {
            long baza = v > 1 ? 3 : 1;

            for (int i = 2; i < v; i++)
            {
                baza += i * 2;
            }

            return baza;
        }

        public static long rowSumOddNumber(long v)
        {
            if(v == 1)
            {
                return 1;
            } else
            {
                baza = v == 2 ? 1 : (v - 1) * v + 1;

                for(int i = 1; i <= v; i++)
                {
                    result =  result + baza;
                    Console.WriteLine(result);
                    baza = baza + 2;
                }
            }
            return result;
        }
    }
}
