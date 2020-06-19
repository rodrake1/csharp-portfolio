using System;
using System.Globalization;
using System.Collections.Generic;
using Course.Entities;

namespace Course
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
        Console.WriteLine($"Product #{i} data:");
        Console.Write("Common, used or imported (c/u/i)? ");
        char type = char.Parse(Console.ReadLine());
        Console.Write("Name: ");
        string name = Console.ReadLine();
        Console.Write("Price: ");
        double price = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        switch (type)
        {
          case 'c':
            list.Add(new Product(name, price));
            break;
          case 'u':
            Console.Write("Manufacture date: ");
            DateTime date = DateTime.Parse(Console.ReadLine());
            list.Add(new UsedProduct(name, price, date));
            break;
          case 'i':
            Console.Write("Customs fee: ");
            double fee = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            list.Add(new ImportedProduct(name, price, fee));
            break;
          default:
            break;
        }
      }

      Console.WriteLine();
      Console.WriteLine("PRICE TAGS:");
      foreach (Product product in list)
      {
        Console.WriteLine(product.PriceTag());
      }
    }
  }
}
