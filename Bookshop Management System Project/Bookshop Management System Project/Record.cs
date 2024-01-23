using System;
using System.Collections.Generic;
using System.IO.Enumeration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bookshop_Management_System_Project
{
    internal class Record
    {
        private const string FilePath = "D:\\Study\\OOP Projects\\Bookshop Management System Project\\BookShop_Records_File.txt";
        private static string[] Records = File.ReadAllLines(FilePath);
        public static void Add_Record()
        {
            Console.Write("Enter book name: ");
            string BookName = Console.ReadLine();
            Console.Write("Enter author name: ");
            string AuthorName = Console.ReadLine();
            Console.Write("Enter number of copies: ");
            int CopiesNumber = int.Parse(Console.ReadLine());

            StreamWriter sw = new StreamWriter(FilePath, true);
            sw.WriteLine($"{BookName},{AuthorName},{CopiesNumber}");
            sw.Close();

            Console.WriteLine("Record added successfully");
            Console.WriteLine("-------------------------------------\n");
        }

        public static void Show_Records()
        {
            Console.WriteLine($"There is {Records.Length} record in the file");
            foreach(string rec in Records)
            {
                Console.WriteLine(rec);
            }
            Console.WriteLine("-------------------------------------\n");
        }

        public static void Check_Availability()
        {
            Console.Write("Enter book name: ");
            string bookname = Console.ReadLine();
            
            foreach(string record in Records)
            {
                string[] Recordfields = record.Split(',');
                if (Recordfields[0] == bookname)
                {
                    Console.WriteLine("Book available");
                    Console.WriteLine($"Book author: {Recordfields[1]}");
                    Console.WriteLine($"Copies number: {Recordfields[2]}");
                    Console.WriteLine("-------------------------------------\n");
                    return;
                }
            }
            Console.WriteLine("Book is not available");
            Console.WriteLine("-------------------------------------\n");
        }

        public static void Edit_Record()
        {
            Console.WriteLine($"There is {Records.Length} record in the file");
            Console.Write("Enter record number to edit: ");
            int RecordNumber = int.Parse(Console.ReadLine());

            if(RecordNumber > 0 && RecordNumber <= Records.Length)
            {
                Console.WriteLine($"Record {RecordNumber} has following data");
                
                string[] Recordfields = Records[RecordNumber - 1].Split(',');
                Console.WriteLine($"Book name: {Recordfields[0]}");
                Console.WriteLine($"Author name: {Recordfields[1]}");
                Console.WriteLine($"Copies number: {Recordfields[0]}");
                Console.WriteLine("---------------------------- \n");

                Console.WriteLine("Enter data to modify");
                Console.Write("Enter book name: ");
                Recordfields[0] = Console.ReadLine();
                Console.Write("Enter author name: ");
                Recordfields[1] = Console.ReadLine();
                Console.Write("Enter number of copies: ");
                Recordfields[2] = Console.ReadLine();

                string strRecord = string.Join(',', Recordfields);
                Records[RecordNumber - 1] = strRecord;
                File.WriteAllLines(FilePath, Records);
                
                Console.WriteLine("Record updated successfully");
                Console.WriteLine("-------------------------------------\n");
            }
            else
            {
                Console.WriteLine("Record not found");
                Console.WriteLine("-------------------------------------\n");
            }
        }

        public static void Delete_Record()
        {
            Console.Write("Enter book name to delete: ");
            string bookname = Console.ReadLine();

            string[] NewRecords = new string[Records.Length - 1];
            int RecordNumber = 0;

            for(int i = 0; i < Records.Length; i++) 
            {
                string[] RecordFields = Records[i].Split(',');
                if (RecordFields[0] == bookname)
                {
                    RecordNumber = i + 1;
                }
            }

            if (RecordNumber == 0)
            {
                Console.WriteLine("Book not found");
                Console.WriteLine("-------------------------------------\n");
                return;
            }

            for(int i = 0; i < Records.Length; i++)
            {
                if(RecordNumber - 1 == i)
                    continue;
                NewRecords[i] = Records[i];
            }

            File.WriteAllLines(FilePath, NewRecords);
            Console.WriteLine("Record deleted successfully");
            Console.WriteLine("-------------------------------------\n");
        }
    }
}
