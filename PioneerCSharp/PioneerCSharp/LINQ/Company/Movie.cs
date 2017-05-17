using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PioneerCSharp.LINQ.Company
{
    public class Movie
    {
        public string Name { get; set; }
        public float Rate { get; set; }

        private int _year;

        public int Year
        {
            get
            {
                Console.WriteLine($"Return {_year} for {Name}");
                return _year;
            }
            set { _year = value; }
        }

    }
}
