﻿using DemoDatabaseFirst.Models;
using Microsoft.EntityFrameworkCore;

namespace DemoDatabaseFirst
{
    class Program
    {
        static void Main(string[] args)
        {
            MyStoreContext myStore = new MyStoreContext();
            var products = from p in myStore.Products
                           select new { p.ProductName, p.CategoryId };
            foreach (var p in products)
            {
                Console.WriteLine($"ProductName: {p.ProductName}, CategoryID: {p.CategoryId}");
            }
            Console.WriteLine("-----");
            IQueryable<Category> cats = myStore.Categories.Include(c => c.Products);
            foreach (Category c in cats)
            {
                Console.WriteLine($"CategoryID: {c.CategoryId}");
            }
            Console.ReadLine();
        }
    }
}