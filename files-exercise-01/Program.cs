using System;
using System.IO;
using System.Globalization;

namespace Course
{
  class Program
  {
    static void Main(string[] args)
    {
      Console.Write("Enter file full path: ");
      string sourceFilePath = Console.ReadLine();

      try
      {
        string sourceFolderPath = Path.GetDirectoryName(sourceFilePath);
        string targetFolderPath = sourceFolderPath + @"\out";
        string targetFilePath = targetFolderPath + @"\summary.csv";

        Directory.CreateDirectory(targetFolderPath);

        string[] lines = File.ReadAllLines(sourceFilePath);

        using (StreamWriter sw = File.AppendText(targetFilePath))
        {
          foreach (string line in lines)
          {
            string[] productInfo = line.Split(',');
            string name = productInfo[0];
            double price = double.Parse(productInfo[1], CultureInfo.InvariantCulture);
            int quantity = int.Parse(productInfo[2]);
            double total = price * quantity;

            sw.WriteLine($"{name},{total.ToString("F2", CultureInfo.InvariantCulture)}");
          }

          Console.WriteLine("summary.csv file created with success!");
        }
      }
      catch (IOException e)
      {
        Console.WriteLine("An error has occured");
        Console.WriteLine(e.Message);
      }
    }
  }
}
