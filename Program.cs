using System;

namespace new_project_test
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("This is the first line");
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
    


    /// <summary>
    /// Werner workking stuff
    /// </summary>
    internal class Program
    {
        static void Menusystem(string[] args)
        {
            int Tasks;
            do
            {

                Console.WriteLine("Enter the numbers to choose the tasks: ");
                Console.WriteLine("1. Task 1 \n2. Task 2 \n3. Task3 \n4. Task 4 \n 0. Exit menu");


                string temp = Console.ReadLine();
                Tasks = Convert.ToInt32(temp);
                Console.Clear();
                switch (Tasks)
                {
                    case 0:
                        Console.WriteLine("Exiting system...");
                        break;

                    case 1:
                        Task1();
                        break;

                    case 2:
                        Task2();
                        break;

                    case 3:
                        Task3();
                        break;

                    case 4:
                        Task4();
                        break;

                    default:
                        Console.WriteLine("Invalid choice. Try again.");
                        break;
                }
                Console.Clear();
            } while (Tasks != 0);
        }
        public static void Task1()
        {
            Console.WriteLine("This is task one");
            Console.WriteLine("Press any key to exit");
            Console.ReadLine();
        }
        public static void Task2()
        {
            Console.WriteLine("This is task two");
            Console.WriteLine("Press any key to exit");
            Console.ReadLine();
        }
        public static void Task3()
        {
            Console.WriteLine("This is task three");
            Console.WriteLine("Press any key to exit");
            Console.ReadLine();
        }
        public static void Task4()
        {
            Console.WriteLine("This is task four");
            Console.WriteLine("Press any key to exit");
            Console.ReadLine();
        }



    }
}

