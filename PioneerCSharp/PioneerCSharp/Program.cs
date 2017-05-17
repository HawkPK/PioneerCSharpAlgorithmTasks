using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PioneerCSharp.LINQ;
using PioneerCSharp.LINQ.Company;
using PioneerCSharp.LINQ.Extensions;
using PioneerCSharp._7_kyu.TheHiddenWord;

namespace PioneerCSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            //Task1();
            Task2();
        }

        private static void Task2()
        {
            var movies = new List<Movie>
            {
                new Movie {Name = "Stars", Rate = 8.9f, Year = 2008},
                new Movie {Name = "Earth", Rate = 10.2f, Year = 1984},
                new Movie {Name = "Europea", Rate = 5.5f, Year = 1988},
                new Movie {Name = "Asia", Rate = 3.4f, Year = 1970}
            };


            var query = movies.Filter(e => e.Year > 2000);

            //foreach (var move in movies)
            //{
            //    Console.WriteLine(move.Name);
            //}

            Console.ReadKey();
        }

        private static void TryHiddenWord()
        {
            HiddenWord.Hide(637);
        }

        public static void Task1()
        {
            IEnumerable<Employee> dev = new Employee[]
            {
                new Employee {Id = 1, Name = "Pawel"},
                new Employee {Id = 2, Name = "Karol"}
            };

            Employee[] dev2 = new Employee[]
            {
                new Employee {Id = 1, Name = "Pawel"},
                new Employee {Id = 2, Name = "Karol"}
            };

            
            IEnumerable<Employee> sales = new List<Employee>()
            {
                new Employee {Id = 3, Name = "Piotr" }
            };

            var query = dev.Where(e => e.Name.StartsWith("P"));

            var query2 = from developer in dev
                where developer.Name.Length > 2
                orderby developer.Name
                select developer;

            foreach (Employee emp in query2)
            {
                Console.WriteLine(emp.Name);
            }

            Console.WriteLine(sales.Count());
            Console.ReadKey();
        }
    }
}
