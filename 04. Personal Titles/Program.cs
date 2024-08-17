using System;

namespace _04._Personal_Titles
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double age = double.Parse(Console.ReadLine());
            string gender = Console.ReadLine();

            //1. проверка за пола
            if (gender == "m")
            {
                //проверка за възрастта
                if (age < 16)
                {
                    Console.WriteLine("Master");
                }
                else   //age >= 16
                {
                    Console.WriteLine("Mr.");
                }
            }
            else if (gender == "f")
            {
                //проверка за възрастта
                if (age < 16)
                {
                    Console.WriteLine("Miss");
                }
                else  //age >= 16
                {
                    Console.WriteLine("Ms.");
                }
            }
        
       } 
        }
    }
