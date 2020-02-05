using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace GenericsLesson
{
    class Program
    {
        static void Main(string[] args)
        {

            GenericObject<int, int> obj = new GenericObject<int, int>();
            obj.Swap(100, 200);

            GenericObject<char, char> obj2 = new GenericObject<char, char>();
            obj2.Swap('A', 'a');


            //**************************************************//
            Dictionary<int, string> movies = new Dictionary<int, string>();

            movies.Add(1, "Joker");
            movies.Add(2, "Star Wars: Ride of the Skywalker");
            movies.Add(3, "Avengers Endgame");
            movies.Add(4, "Toy Story 4");            

            foreach (KeyValuePair<int, string> item in movies)
            {
                Console.WriteLine($"Key: {item.Key, -5} Value: {item.Value}");
            }

            Console.WriteLine();
            Console.WriteLine("****************************");
            Console.WriteLine();

            foreach (var item in movies.Keys)
            {
                Console.WriteLine($"Key: {item}");
            }

            Console.WriteLine();
            Console.WriteLine("****************************");
            Console.WriteLine();

            foreach (var item in movies.Values)
            {
                Console.WriteLine($"Value: {item}");
            }

            Console.WriteLine();
            Console.WriteLine("****************************");
            Console.WriteLine();

            string value = "Bobs Burger Movie";
            Console.WriteLine($"Does this dictionary contain {value}? {movies.ContainsValue(value)}");


            Console.WriteLine();
            Console.WriteLine("****************************");
            Console.WriteLine();

            foreach (var item in movies.OrderByDescending(x => x.Value))
            {                
                Console.WriteLine($"Key: {item.Key, -5} Value: {item.Value}");
            }

            Console.ReadLine();
        }
    }
}
