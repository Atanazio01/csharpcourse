using HashSetAndSortedSet.Entities;
using System;
using System.Collections.Generic;

namespace HashSetAndSortedSet
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // HashSet<string> set = new HashSet<string>();
            // 
            // set.Add("TV");
            // set.Add("Notebook");
            // set.Add("Tablet");
            // 
            // Console.WriteLine(set.Contains("Computer"));
            // 
            // foreach (string item in set)
            // {
            //     Console.WriteLine(item);
            // }

            SortedSet<int> a = new SortedSet<int>() { 10, 0, 2, 4, 5, 6, 8, };
            SortedSet<int> b = new SortedSet<int>() { 5, 6, 7, 8, 9, 10 };

            // union
            SortedSet<int> c = new SortedSet<int>(a);
            c.UnionWith(b);
            PrintCollection(c);

            // intersection
            SortedSet<int> d = new SortedSet<int>(a);
            d.IntersectWith(b);
            PrintCollection(d);

            // difference
            SortedSet<int> e = new SortedSet<int>(a);
            e.ExceptWith(b);
            PrintCollection(e);

            HashSet<string> set = new HashSet<string>();

            set.Add("Maria");
            set.Add("Alex");

            Console.WriteLine(set.Contains("Maria"));

            HashSet<Product> set2 = new HashSet<Product>();
            set2.Add(new Product("TV", 900.0));
            set2.Add(new Product("Notebook", 1200.0));

            HashSet<Point> set3 = new HashSet<Point>();
            set3.Add(new Point(3, 4));
            set3.Add(new Point(5, 10));

            Product prod = new Product("Notebook", 1200.0);
            Console.WriteLine(set2.Contains(prod));

            Point p = new Point(5, 10);
            Console.WriteLine(set3.Contains(p));
        }

        static void PrintCollection<T>(IEnumerable<T> collection)
        {
            foreach (T item in collection)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
        }
    }
}