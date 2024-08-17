using System;

namespace _02._Weekend_or_Working_Day
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string dayOfWeek = Console.ReadLine();
            //Monday -> Working day
            //Tuesday -> Working day
            //Wednesday -> Working day
            //Thursday -> Working day
            //Friday -> Working day
            //Saturday -> Weekend
            //Sunday -> Weekend
            //other -> Error

            //switch -> серия от проверки за точни стойности на 1 променлива
            switch (dayOfWeek)
            {
                case "Monday":
                case "Tuesday":
                case "Wednesday":
                case "Thursday":
                case "Friday":
                    Console.WriteLine("Working day");
                    break;
                case "Saturday":
                case "Sunday":
                    Console.WriteLine("Weekend");
                    break;
                default:
                    Console.WriteLine("Error");
                    break;
            }
        }
    }
}
