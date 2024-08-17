
 using System;
using System.Dynamic;
 
namespace TradeCommissions
{
    class Program
    {
        static void Main(string[] args)
        {
            string city = Console.ReadLine();
            double sales = double.Parse(Console.ReadLine());
            double commission = 0;
            bool isValid = true;
 
            switch (city)
            {
                case "Sofia":
                    if (sales < 0)
                    {
                        isValid = false;
                    }
                    else if (0 <= sales && sales <= 500)
                    {
                        commission = sales * 0.05;
                    }
                    else if (500 <= sales && sales <= 1000)
                    {
                        commission = sales * 0.07;
                    }
                    else if (1000 <= sales && sales <= 10000)
                    {
                        commission = sales * 0.08;
                    }
                    else if (sales > 10000)
                    {
                        commission = sales * 0.12;
                    }
                    break;
 
                case "Varna":
                    if (sales < 0)
                    {
                        isValid = false;
                    }
                    else if (0 <= sales && sales <= 500)
                    {
                        commission = sales * 0.045;
                    }
                    else if (500 <= sales && sales <= 1000)
                    {
                        commission = sales * 0.075;
                    }
                    else if (1000 <= sales && sales <= 10000)
                    {
                        commission = sales * 0.10;
                    }
                    else if (sales > 10000)
                    {
                        commission = sales * 0.13;
                    }
                    break;
 
                case "Plovdiv":
                    if (sales < 0)
                    {
                        isValid = false;
                    }
                    else if (0 <= sales && sales <= 500)
                    {
                        commission = sales * 0.055;
                    }
                    else if (500 <= sales && sales <= 1000)
                    {
                        commission = sales * 0.08;
                    }
                    else if (1000 <= sales && sales <= 10000)
                    {
                        commission = sales * 0.12;
                    }
                    else if (sales > 10000)
                    {
                        commission = sales * 0.145;
                    }
                    break;
 
                default:
                    isValid = false;
                    break;
            }
            if (isValid)
            {
                Console.WriteLine($"{commission:f2}");
            }
            else
            {
                Console.WriteLine("error");
            }
        }
    }
}
        }
    }
}
