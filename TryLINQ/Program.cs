using System;
using System.Collections.Generic;
using System.Linq;

namespace TryLINQ
{
    public static class CountryExtension
    {
        public static Countries RandomCountry(this IEnumerable<Countries> countries)
        {
            Random rnd = new Random();
            return countries.ElementAt(rnd.Next(1, countries.Count()));
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            var countryArray = Generatecountries();
            //Uppg2(countryArray);
            //Uppg3(countryArray);
            //Uppg4(countryArray);
            //Uppg5(countryArray);
            //Uppg6(countryArray);
            //Uppg7(countryArray);
            //Uppg8(countryArray);
            //Uppg9(countryArray);
            //Uppg10(countryArray);
            //Uppg11(countryArray);
            //Uppg12(countryArray);
            //Uppg13(countryArray);
            //Uppg14(countryArray);            
            //Uppg15(countryArray);
            //Uppg16(countryArray);
            //Uppg17(countryArray);
            //Uppg18(countryArray);
            //Uppg19(countryArray);
            //Uppg20(countryArray);

        }

        private static void Uppg20(IEnumerable<Countries> countryArray)
        {
            var country = countryArray.RandomCountry();
            Console.WriteLine(country.Name);
        }

        private static void Uppg19(IEnumerable<Countries> countryArray)
        {
            var countries = countryArray.Where(c => c.Name.Length == 7);
            double number = 0;
            foreach (var item in countries)
            {
                number += item.Population;
            }
            Console.WriteLine(number);
        }

        private static void Uppg18(IEnumerable<Countries> countryArray)
        {
            var countries = countryArray.OrderBy(c => c.Population).Take(6);
            double number = 0;
            foreach (var item in countries)
            {
                number += item.Population;
            }
            Console.WriteLine(number);
        }

        private static void Uppg17(IEnumerable<Countries> countryArray)
        {
            var countries = countryArray.Select(c => new
            {
                name = c.Name,
                capital = c.Capital
            })
                            .OrderBy(str => new string(str.capital.Reverse().ToArray()));
            foreach (var item in countries)
            {
                Console.WriteLine(item.name + " - " + item.capital);
            }
        }

        private static void Uppg16(IEnumerable<Countries> countryArray)
        {
            var countries = countryArray.Select(c => new
            {
                name = c.Name,
                pop = c.Population * 1000000,
                area = (c.Population * 1000000) / c.Area
            })
                .OrderBy(c => c.pop);

            foreach (var item in countries)
            {
                Console.WriteLine(item.name + " - " + item.pop + " - " + item.area);
            }
        }

        private static void Uppg15(IEnumerable<Countries> countryArray)
        {
            var countries = countryArray.GroupBy(c => (int)c.Population,
                            c => c.Name,
                            (key, g) => new { pop = key, names = g.ToList() })
                            .OrderBy(c => c.pop);
            foreach (var item in countries)
            {
                Console.WriteLine($"Länder med {item.pop} miljoner invånare");
                foreach (var item1 in item.names)
                {
                    Console.WriteLine(item1);
                }
            }
        }

        private static void Uppg14(IEnumerable<Countries> countryArray)
        {
            var countries = countryArray.GroupBy(c => c.Name[0])
                            .Select(x => new { amount = x.Count(), letter = x.Key });
            foreach (var item in countries)
            {
                Console.WriteLine(item.letter + " - " + item.amount);
            }
        }

        private static void Uppg13(IEnumerable<Countries> countryArray)
        {
            var countries = countryArray.Where(c => c.Area >= 500000)
                            .OrderBy(c => c.Name).Take(3);
            foreach (var item in countries)
            {
                Console.WriteLine(item.Name);
            }
        }

        private static void Uppg12(IEnumerable<Countries> countryArray)
        {
            var countries = countryArray.Where(c => c.Population >= 7)
                            .OrderBy(c => c.Population).Take(3);
            foreach (var item in countries)
            {
                Console.WriteLine(item.Name);
            }
        }

        private static void Uppg11(IEnumerable<Countries> countryArray)
        {
            var countries = countryArray.OrderBy(c => c.Population).Take(5);
            foreach (var item in countries)
            {
                Console.WriteLine(item.Name);
            }
        }

        private static void Uppg10(IEnumerable<Countries> countryArray)
        {
            var countries = countryArray.Where(c => c.Name.Length > c.Capital.Length);
            foreach (var item in countries)
            {
                Console.WriteLine(item.Name);
            }
        }

        private static void Uppg9(IEnumerable<Countries> countryArray)
        {
            var countries = countryArray.Where(c => c.Name.StartsWith(c.Capital[0]));
            foreach (var item in countries)
            {
                Console.WriteLine(item.Name);
            }
        }

        private static void Uppg8(IEnumerable<Countries> countryArray)
        {
            Console.WriteLine(countryArray.Where(c => c.Area > 10000).Count());
            Console.WriteLine(countryArray.Where(c => c.Area > 100000).Count());
            Console.WriteLine(countryArray.Where(c => c.Area > 1000000).Count());
        }

        private static void Uppg7(IEnumerable<Countries> countryArray)
        {
            var countries = countryArray.Where(c => c.Population < 5);
            foreach (var item in countries)
            {
                Console.WriteLine(item.Name);
            }
        }

        private static void Uppg6(IEnumerable<Countries> countryArray)
        {
            Console.WriteLine(countryArray.Average(c => c.Area));
            var countries = countryArray.Where(c => c.Area <= countryArray.Average(c => c.Area));
            foreach (var item in countries)
            {
                Console.WriteLine(item.Name);
            }
        }

        private static void Uppg5(IEnumerable<Countries> countryArray)
        {
            Console.WriteLine(countryArray.OrderByDescending(c => c.Population)
                            .First().Population);
        }

        private static void Uppg4(IEnumerable<Countries> countryArray)
        {
            var countries = countryArray.OrderByDescending(c => c.Population)
                            .Select(c => new { c.Name });
            foreach (var item in countries)
            {
                Console.WriteLine(item.Name);
            }
        }

        private static void Uppg3(IEnumerable<Countries> countryArray)
        {
            var countries = countryArray.OrderBy(c => c.Name);
            foreach (var item in countries)
            {
                Console.WriteLine(item.Name);
            }
        }

        private static void Uppg2(IEnumerable<Countries> countryArray)
        {
            Console.WriteLine(countryArray.Select(c => c.Name)
                            .First());
            Console.WriteLine(countryArray.Select(c => c.Name)
                .Last());
        }

        private static IEnumerable<Countries> Generatecountries()
        {
            Countries[] countryList = { new Countries("Sverige", "Stockholm", 10.07, 450295),
            new Countries("Norge", "Oslo", 5.27, 323802),
            new Countries("Island", "Reykyavik", 0.33, 102775),
            new Countries("Danmark", "Köpenhamn", 5.75, 42931),
            new Countries("Finland", "Helsinki", 5.51, 338424),
            new Countries("Belgien", "Bryssel", 11.30, 30528),
            new Countries("Tyskland", "Berlin", 82.18, 357168),
            new Countries("Frankrike", "Paris", 66.99, 640679),
            new Countries("Storbritannien", "London", 60.80, 209331),
            new Countries("Niue", "Alofi", 0.0016, 261),
            new Countries("Mongoliet", "Kuala Lumpur", 3.08, 1566000),
            new Countries("Polen", "Warsawa", 38.63, 312679),
            new Countries("Spanien", "Madrid", 46.5, 505990),
            new Countries("Portugal", "Lissabon", 10.31, 92212),
            new Countries("Italien", "Rom", 60.59, 301338),
            new Countries("Grekland", "Aten", 11.18, 131957),
            new Countries("Luxemburg", "Luxemburg", 0.58, 2586),
            new Countries("Liechtenstein", "Vaduz", 0.038, 160)};
            return countryList;
        }
    }
    public class Countries
    {
        public Countries(string name, string capital, double pop, double area)
        {
            Name = name;
            Capital = capital;
            Population = pop;
            Area = area;
        }
        public string Name { get; set; }
        public string Capital { get; set; }
        public double Population { get; set; }
        public double Area { get; set; }
    }
}
