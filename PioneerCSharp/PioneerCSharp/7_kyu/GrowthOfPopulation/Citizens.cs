using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PioneerCSharp._7_kyu.GrowthOfPopulation
{
    public class Citizens
    {
        private static int year;

        public static int GrowPopulation(int population, double growth, int newCitizens, int goal)
        {
            year = 0;
            while (goal > population)
            {
                population = population + (int)(population * (growth / 100)) + newCitizens;
                year += 1;
            }
            return year;
        }
    }
}
