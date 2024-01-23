using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bookshop_Management_System_Project
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("**Bookshop Management System**");
                Console.WriteLine("Select one option below");
                Console.WriteLine("        1-->Add record to file");
                Console.WriteLine("        2-->Show record from file");
                Console.WriteLine("        3-->Search record from file");
                Console.WriteLine("        4-->Update record");
                Console.WriteLine("        5-->Delete record");
                Console.WriteLine("        6-->Quit");
                Console.Write("Enter your choice: ");
                
                int choice;
                if(!int.TryParse(Console.ReadLine(), out choice))
                {
                    Console.WriteLine("Invalid choice. Please try again.\n");
                    continue;
                }

                switch (choice)
                {
                    case 1:
                        Record.Add_Record();
                        break;
                    case 2:
                        Record.Show_Records();
                        break;
                    case 3:
                        Record.Check_Availability();
                        break;
                    case 4:
                        Record.Edit_Record();
                        break;
                    case 5:
                        Record.Delete_Record();
                        break;
                    case 6:
                        return;
                    default:
                        Console.WriteLine("Invalid choice. Please try again.\n");
                        break;
                }

            }
        }
    }
}