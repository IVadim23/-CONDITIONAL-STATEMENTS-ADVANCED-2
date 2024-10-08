﻿using System;

namespace _05._Small_Shop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string product = Console.ReadLine();
            string city = Console.ReadLine();
            double quantity = double.Parse(Console.ReadLine());

            if (city == "Sofia")
            {
                switch (product)
                {
                    case "coffee":
                        Console.WriteLine(0.50 * quantity);
                        break;
                    case "water":
                        Console.WriteLine(0.80 * quantity);
                        break;
                    case "beer":
                        Console.WriteLine(1.20 * quantity);
                        break;
                    case "sweets":
                        Console.WriteLine(1.45 * quantity);
                        break;
                    case "peanuts":
                        Console.WriteLine(1.60 * quantity);
                        break;
                }
            }
            else if (city == "Plovdiv")
            {
                switch (product)
                {
                    case "coffee":
                        Console.WriteLine(0.40 * quantity);
                        break;
                    case "water":
                        Console.WriteLine(0.70 * quantity);
                        break;
                    case "beer":
                        Console.WriteLine(1.15 * quantity);
                        break;
                    case "sweets":
                        Console.WriteLine(1.30 * quantity);
                        break;
                    case "peanuts":
                        Console.WriteLine(1.50 * quantity);
                        break;
                }
            }
            else if (city == "Varna")
            {
                switch (product)
                {
                    case "coffee":
                        Console.WriteLine(0.45 * quantity);
                        break;
                    case "water":
                        Console.WriteLine(0.70 * quantity);
                        break;
                    case "beer":
                        Console.WriteLine(1.10 * quantity);
                        break;
                    case "sweets":
                        Console.WriteLine(1.35 * quantity);
                        break;
                    case "peanuts":
                        Console.WriteLine(1.55 * quantity);
                        break;
                }
            }
        }
    }
}
