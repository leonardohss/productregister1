using System;
using ProductRegister.Entities;
using System.Globalization;
using System.Collections.Generic;

namespace ProductRegister
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Product> prds = new List<Product>();

            Console.Write("Enter the number of products: ");
            int qt = int.Parse(Console.ReadLine());

            for(int x = 1; x <= qt; x++){
                Console.WriteLine($"Product #{x} data: ");
                Console.Write("Common, used or imported? (c/u/i): ");
                char type = char.Parse(Console.ReadLine());
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Price: ");
                double price = double.Parse(Console.ReadLine());
                switch (type)
                {
                    case 'c':
                        prds.Add(new Product(name, price));
                        break;
                    case 'u':
                        Console.Write("Manufacture Date (DD/MM/YYYY): ");
                        DateTime mdate = DateTime.Parse(Console.ReadLine());
                        prds.Add(new UsedProduct(name, price, mdate));
                        break;
                    case 'i':
                        Console.Write("Customs Fee: ");
                        double cfee = double.Parse(Console.ReadLine());
                        prds.Add(new ImportedProduct(name, price, cfee));
                        break;
                    default:
                        prds.Add(new Product(name, price));
                        break;
                }
            }


            Console.WriteLine();
            Console.WriteLine("Price Tags: ");
            foreach (Product x in prds)
            {
                Console.WriteLine(x.PriceTag());
            }
        }
    }
}
