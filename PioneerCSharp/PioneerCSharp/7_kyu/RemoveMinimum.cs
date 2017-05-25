using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Task
//Source: https://www.codewars.com/kata/remove-the-minimum/train/csharp
//Given an array of integers, remove the smallest value.Do not mutate the original array/list.
//If there are multiple elements with the same value, 
//remove the one with a lower index.If you get an empty array/list, return an empty array/list.
//Don't change the order of the elements that are left.
//Examples
//Remover.RemoveSmallest(new List<int>{1,2,3,4,5}) = new List<int>{2,3,4,5}
//Remover.RemoveSmallest(new List<int>{5,3,2,1,4}) = new List<int>{5,3,2,4}
//Remover.RemoveSmallest(new List<int>{2,2,1,2,1}) = new List<int>{2,2,2,1}

namespace PioneerCSharp._7_kyu
{
    public class RemoveMinimum
    {
        private static int temp;

        public static List<int> RemoveSmallestNum(List<int> numbers)
        {
            temp = int.MaxValue;
            foreach (var elem in numbers)
            {
                if(temp > elem)
                {
                    temp = elem;
                }
            }

            numbers.Remove(temp);

            return numbers;
        }

        public static List<int> RemoveSmallestNumRefactor(List<int> numbers)
        {
            return numbers.Where((element, valueForCondition) => valueForCondition != numbers.IndexOf(numbers.Min())).ToList();
        }
    }
}
