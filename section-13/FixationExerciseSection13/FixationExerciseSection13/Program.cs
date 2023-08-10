using FixationExerciseSection13.Entities;
using System;
using System.Globalization;

namespace FixationExerciseSection13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string sourcePath = @"c:\temp\sale-itens.csv";
            List<Order> list = new List<Order>();

            try
            {
                using (StreamReader sr = File.OpenText(sourcePath))
                {
                    while (!sr.EndOfStream)
                    {
                        string product = sr.ReadLine();
                        string name = product.Split(',')[0];
                        double value = double.Parse(product.Split(",")[1], CultureInfo.InvariantCulture);
                        int quantity = int.Parse(product.Split(",")[2]);
                        list.Add(new Order(name, value, quantity));
                    }
                }

                Directory.CreateDirectory(Path.GetDirectoryName(sourcePath) + "\\out");
                string targetPath = @"c:\temp\out\summary.csv";

                using (StreamWriter sw = File.AppendText(targetPath))
                {
                    foreach (Order item in list)
                    {
                        sw.WriteLine($"{item.Name},{item.Total().ToString("F2", CultureInfo.InvariantCulture)}");
                    }
                }
            }
            catch (IOException e)
            {
                Console.WriteLine("An error ocurred");
                Console.WriteLine(e.Message);
            }
        }
    }
}