using System;
using ConsoleApp26.Entities;
using System.Collections.Generic;
using System.Globalization;
using System.Numerics;

namespace ConsoleApp26
{
    class Program
    {
        static void Main(string[] args)
        {
           
            List<Product> list = new List<Product>();
            Console.WriteLine("Enter the numer of products :");
            int n = int.Parse(Console.ReadLine());
            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine($"Product #{i} Data :");
                Console.WriteLine("Common,used or imported ?(c/u/i)");
                char choice = char.Parse(Console.ReadLine());
                if (choice == 'c' || choice == 'C')
                {
                    Console.Write("Name :");
                    string name = Console.ReadLine();
                    Console.Write("Price : $ ");
                    double price = double.Parse(Console.ReadLine());
                    list.Add(new Product(name, price));


                }
                if (choice == 'u' || choice == 'U')
                {
                    Console.Write("Name :");
                    string name = Console.ReadLine();
                    Console.Write("Price : $");
                    double price = double.Parse(Console.ReadLine());
                    Console.Write("ManuFacture Date (DD/MM/YYYY)");
                    DateTime date = Convert.ToDateTime(Console.ReadLine());
                   
                    list.Add(new UsedProduct(name, price,date));

                }
                if (choice == 'i' || choice == 'I')
                {
                    Console.Write("Name :");
                    string name = Console.ReadLine();
                    Console.Write("Price : $ ");
                    double price = double.Parse(Console.ReadLine());
                    Console.Write("Customs Fee :");
                    double fee = double.Parse(Console.ReadLine());
                    list.Add(new ImportedProduct(name, price,fee));
                }
            }
            Console.WriteLine();
            Console.WriteLine("PRICE TAGS:");
            foreach (Product prod in list)
            {
                Console.WriteLine(prod.PriceTag());
            }
        }
    }
}
