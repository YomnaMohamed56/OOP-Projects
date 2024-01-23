using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bus_Reservation_System_Project
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("**Bus_Reservation_System**");
                Console.WriteLine("      1.Install");
                Console.WriteLine("      2.Reservation");
                Console.WriteLine("      3.Show");
                Console.WriteLine("      4.Buses Available");
                Console.WriteLine("      5.Exit");
                Console.Write("      Enter your choice:-> ");

                int choice;
                if (!int.TryParse(Console.ReadLine(), out choice))
                {
                    Console.WriteLine("Invalid choice. Please try again");
                    Console.WriteLine("---------------------------------------\n");
                    continue;
                }

                switch (choice)
                {
                    case 1:
                        Bus_System.Install_Bus();
                        break;
                    case 2:
                        Bus_System.Reservation();
                        break;
                    case 3:
                        Bus_System.Show();
                        break;
                    case 4:
                        Bus_System.Buses_Available();
                        break;
                    case 5:
                        return;
                    default:
                        Console.WriteLine("Invalid choice. Please try again");
                        Console.WriteLine("---------------------------------------\n");
                        break;
                }
            }
        }
    }
}