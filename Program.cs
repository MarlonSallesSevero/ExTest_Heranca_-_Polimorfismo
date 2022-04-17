using System;
using System.Globalization;
using System.Collections.Generic;
using ExFinal.Entities;
namespace ExFinal
{
    internal class Program
    {
        static void Main(string[] args)
        {

            double sum = 0;
            List<TaxPayer> list = new List<TaxPayer>();
            Console.Write("Enter the number of tax payers: ");
            int v = int.Parse(Console.ReadLine());
            for (int i = 1; i <= v; i++)
            {
                Console.WriteLine($"Tax payer #{i} data:");
                Console.Write("Individual or company (i/c)?");
                char c = char.Parse(Console.ReadLine());
                Console.Write("Name:");
                string name = Console.ReadLine();
                Console.Write("Anual income: ");
                double anualIn = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                if (c == 'i')
                {
                    Console.Write("Health expenditures:");
                    double health = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    list.Add(new Individual(name, anualIn, health));
                }
                else
                {
                    Console.Write("Number of employees: ");
                    int empl = int.Parse(Console.ReadLine());
                    list.Add(new Company(name, anualIn, empl));
                }
            }
            Console.WriteLine();
            Console.WriteLine("TAXES PAID: ");
            foreach (TaxPayer tx in list)
            {
                Console.WriteLine($"{tx.Nome}: $ {tx.Tax().ToString("F2", CultureInfo.InvariantCulture)}");
                sum += tx.Tax();
            }
            Console.WriteLine();
            Console.WriteLine($"TOTAL TAXES: $ {sum.ToString("F2", CultureInfo.InvariantCulture)}");
            string a = Console.ReadLine();
        }
    }
}
