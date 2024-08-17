using System;

namespace _8._Cinema_Tickets
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string dayOfWeek = Console.ReadLine();
            //Monday или Tuesday или Friday -> 12
            //Wednesday или Thursday -> 14
            //Saturday или Sunday -> 16
            if (dayOfWeek == "Monday" || dayOfWeek == "Tuesday" || dayOfWeek == "Friday")
            {
                Console.WriteLine(12);
            }
            else if (dayOfWeek == "Wednesday" || dayOfWeek == "Thursday")
            {
                Console.WriteLine(14);
            }
            else if (dayOfWeek == "Saturday" || dayOfWeek == "Sunday")
            {
                Console.WriteLine(16);
            }
        }
    }
}
