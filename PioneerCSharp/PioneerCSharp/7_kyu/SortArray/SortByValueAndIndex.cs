using System;

namespace PioneerCSharp
{
    public class SortByValueAndIndex
    {

        public static int[] SortElement(int[] v)
        {
            int pointer = 0; ;
            int min = int.MaxValue;
            int[] finalResult = new int[v.Length];
            int counter = 0;
            while (finalResult.Length > counter)
            {
                for (int i = 0; i < v.Length; i++)
                {
                    if (v[i]*(i+1) < min && v[i] != -1)
                    {
                        min = v[i];
                        pointer = i;
                    }
                }

                v[pointer] = -1;
                finalResult[counter] = min;
                min = int.MaxValue;
                counter++;
            }

            for (int i = 0; i < finalResult.Length; i++)
            {
                Console.WriteLine(finalResult[i]);
            }

            return finalResult;
        }
    }
}