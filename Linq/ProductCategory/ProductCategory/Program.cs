﻿using ProductCategory.Entities;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;

namespace ProductCategory
{
    internal class Program
    {
        static void Print<T>(string message, IEnumerable<T> collection)
        {
            Console.WriteLine(message);
            foreach (T item in collection)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();
        }

        static void Main(string[] args)
        {
            Category c1 = new Category() { Id = 1, Name = "Tools", Tier = 2 };
            Category c2 = new Category() { Id = 1, Name = "Computer", Tier = 1 };
            Category c3 = new Category() { Id = 1, Name = "Electronics", Tier = 1 };

            List<Product> products = new List<Product>() {
                new Product() { Id = 1, Name = "Computer", Price = 1100.0, Category = c2 },
                new Product() { Id = 2, Name = "Hammer", Price = 90.0, Category = c1 },
                new Product() { Id = 3, Name = "TV", Price = 1700.0, Category = c3 },
                new Product() { Id = 4, Name = "Notebook", Price = 1300.0, Category = c2 },
                new Product() { Id = 5, Name = "Saw", Price = 80.0, Category = c1 },
                new Product() { Id = 6, Name = "Tablet", Price = 700.0, Category = c2 },
                new Product() { Id = 7, Name = "Camera", Price = 700.0, Category = c3 },
                new Product() { Id = 8, Name = "Printer", Price = 350.0, Category = c3 },
                new Product() { Id = 9, Name = "MacBook", Price = 1800.0, Category = c2 },
                new Product() { Id = 10, Name = "Sound Bar", Price = 700.0, Category = c3 },
                new Product() { Id = 11, Name = "Level", Price = 70.0, Category = c1 }
            };

            var r1 = products.Where(p => p.Category.Tier == 1 && p.Price < 900.00);

            Print("TIER 1 AND PRICE < 900.00: ", r1);

            var r2 = products
                .Where(p => p.Category.Name == "Tools")
                .Select(p => p.Name);

            Print("NAMES OF PRODUCTS FROM TOOLS", r2);

            var r3 = products.Where(p => p.Name[0] == 'C').Select(p => new { p.Name, p.Price, CategoryName = p.Category.Name });
            Print("NAMES STARTED WITH 'C': ", r3);

            var r4 = products
                .Where(p => p.Category.Tier == 1)
                .OrderBy(p => p.Price)
                .ThenBy(p => p.Name);

            Print("TIER 1 ORDERED BY PRICE THEN BY NAME: ", r4);

            var r5 = r4
                .Skip(2)
                .Take(4);
            Print("TIER 1 ORDERED BY PRICE THEN BY NAME, SKIP 2 TAKE 4: ", r5);

            var r6 = products.First();
            Console.WriteLine("FIRST: " + r6);
            Console.WriteLine();

            var r7 = products
                .Where(p => p.Price > 3000.00)
                .FirstOrDefault();
            Console.WriteLine("FIRST OR DEFAULT: " + r7);
            Console.WriteLine();

            var r8 = products
                .Where(p => p.Id == 3)
                .SingleOrDefault();
            Console.WriteLine("SINGLE OR DEFAULT: " + r8);
            Console.WriteLine();

            var r9 = products.Max(p => p.Price);
            Console.WriteLine("MAX PRICE: "  + r9);

            var r11 = products.Min(p => p.Price);
            Console.WriteLine("MIN PRICE: " + r11);

            var r12 = products
                .Where(p => p.Category.Id == 1)
                .Sum(p => p.Price);
            Console.WriteLine();
            Console.WriteLine("CATEGORY 1 SUM PRICES: " + r12);

            var r13 = products
                .Where(p => p.Category.Id == 1)
                .Average(p => p.Price);
            Console.WriteLine();
            Console.WriteLine("CATEGORY 1 AVG PRICES: " + r13);

            var r14 = products.Where(p => p.Category.Id == 5).Select(p => p.Price).DefaultIfEmpty(0.00).Average();
            Console.WriteLine("CATEGORY 5 AVG PRICES: " + r14);

            var r15 = products.Where(p => p.Category.Id == 1).Select(p => p.Price).Aggregate(0.0,(x,y) => x+y);
            Console.WriteLine("CATEGORY 1 AGGREGATE SUM: " + r15);

            var r16 = products.GroupBy(p => p.Category);
            foreach(IGrouping<Category, Product> group in r16)
            {
                Console.WriteLine("CATEGORY: " + group.Key.Name + ": ");
                foreach(Product prod in group)
                {
                    Console.WriteLine(prod);
                }
            }
        }
    }
}
