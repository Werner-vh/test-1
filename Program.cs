using System;

namespace new_project_test
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("This is the first line");
            Console.WriteLine("enter your birthday");
            string input = Console.ReadLine();
            int first = input.IndexOf('/');
            int second = input.IndexOf('/', first + 1);

            string daystr = input.Substring(0, first);
            string monthstr = input.Substring(first + 1, second - first - 1);
            string yearstr = input.Substring(second + 1);

            int day = int.Parse(daystr);
            int month = int.Parse(monthstr);
            int year = int.Parse(yearstr);

            Console.WriteLine($"year: {year}");
            Console.WriteLine($"month: {month}");
            Console.WriteLine($"day: {day}");

            Console.ReadLine();
        }

		static void JacksMethod()
		{
	    		const double AUD = 0.8085, USD = 0.8272, GBP = 0.5457, YEN = 76.23, EUR = 0.6297;

            		Console.OutputEncoding = System.Text.Encoding.UTF8;

            		Console.Write("Enter amount to convert (NZD): ");
            		double NZD = Convert.ToDouble(Console.ReadLine());

            		Console.WriteLine($"{ (NZD * AUD):C}");
            		Console.WriteLine($"{ (NZD * USD):C}");
            		Console.WriteLine("£" + $"{ (NZD * GBP):F2}");
            		Console.WriteLine("¥" + $"{(NZD * YEN):F2}");
            		Console.WriteLine("€" + $"{(NZD * YEN):F2}");

            		Console.ReadLine();

            		Console.Write("=" + $"{(MilesToKm()):F2}" + " km\n");

            		Console.ReadLine();

            		Console.Write("Total Price: " + $"{(TicketPrices()):C}");

            		Console.ReadLine();

		}

    }
}
