using System;
using System.Collections.Generic;

namespace Ex1Delegates
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var numbers = new List<int>();

            for (int i = 1; i <= 10; i++)
                numbers.Add(i);

            var greaterThanFive = new Filter(FilterGreaterThanFive);
            var odd = new Filter(FilterOdd);

            var resultGTF = FilterList(numbers, greaterThanFive);

            Console.WriteLine("Greater than five");

            foreach (var number in resultGTF)
                Console.WriteLine(number);

            Console.WriteLine("-----------------------");

            var resultOdd = FilterList(numbers, odd);

            Console.WriteLine("Odd numbers");

            foreach (var number in resultOdd)
                Console.WriteLine(number);
        }

        public delegate bool Filter(int param);

        static IEnumerable<int> FilterList(List<int> numbers, Filter filter)
        {
            var elements = new List<int>();
            numbers.ForEach(x => {
                if (filter(x))
                    elements.Add(x);
            });

            return elements;
        }

        static bool FilterGreaterThanFive(int number)
        {
            return number > 5;
        }

        static bool FilterOdd(int number)
        {
            return number % 2 != 0;
        }
    }
}
