using ExercicioDeFixacaoPolimorfia.Entities;
using System;
using System.Collections.Generic;

namespace ExercicioDeFixacaoPolimorfia
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Product> list = new List<Product>();

            Console.Write("Enter the number of products: ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                Console.Write("Common , used or imported (c/u/i)? ");
                char c = char.Parse(Console.ReadLine());
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Price: ");
                double price = double.Parse(Console.ReadLine());

                if (c == 'c')
                {
                    list.Add(new Product(name, price));
                }

                else if (c == 'u')
                {
                    Console.Write("Manufacture date (mm/DD/YYYY): ");
                    DateTime manufacture = DateTime.Parse(Console.ReadLine());
                    list.Add(new UsedProduct(name, price, manufacture));
                }

                else
                {
                    Console.Write("Customs fee: ");
                    double fee = double.Parse(Console.ReadLine());
                    list.Add(new ImportedProduct(name, price, fee));
                }

            }

            Console.WriteLine();
            Console.WriteLine("Price Tags: ");

            foreach(Product obj in list)
            {
                Console.WriteLine(obj.priceTag());
            }
        }
    }
}
