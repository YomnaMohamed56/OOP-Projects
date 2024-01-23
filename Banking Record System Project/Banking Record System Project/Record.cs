using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Banking_Record_System_Project
{
    internal class Record
    {
        private const string FileName = "Banking_Records_File.txt";
        private const string FilePath = "D:\\Study\\OOP Projects\\Banking Record System Project\\" + FileName;
        private static string[] Records = File.ReadAllLines($"{FilePath}");
        public static void Reed_Data()
        {
            Console.Write("Enter Account Number: ");
            int AccountNumber = int.Parse(Console.ReadLine());
            Console.Write("Enter First Name: ");
            string FirstName = Console.ReadLine();
            Console.Write("Enter Last Name: ");
            string LastName = Console.ReadLine();
            Console.Write("Enter Balance: ");
            decimal Balance = decimal.Parse(Console.ReadLine());
                       
            StreamWriter sw = new StreamWriter($"{FilePath}", true);               
            sw.WriteLine($"{AccountNumber},{FirstName},{LastName},{Balance}");           
            sw.Close();

            Console.WriteLine("Record added successfully\n");
        }

        public static void Show_Data()
        {
            Console.Write("Enter Account Number: ");
            int AccountNumber = int.Parse(Console.ReadLine());
            Console.Write("Enter First Name: ");
            string FirstName = Console.ReadLine();
            Console.Write("Enter Last Name: ");
            string LastName = Console.ReadLine();

            foreach(string Record in Records)
            {
                string[] fields = Record.Split(',');
                if (fields[0] == AccountNumber.ToString() && fields[1] == FirstName && fields[2] == LastName)
                {
                    Console.WriteLine($"Current Balance: {fields[3]}\n");
                    return;
                }
            }
            Console.WriteLine("Record not found\n");
        }

        public static void Search_Record()
        {
            Console.WriteLine($"There is {Records.Length} record in the file");
            Console.Write("Enter record number to search: ");
            int RecordNumber = int.Parse(Console.ReadLine());
            
            if (RecordNumber > 0 && RecordNumber <= Records.Length)
            {
                string[] RecordFields = Records[RecordNumber-1].Split(',');
                Console.WriteLine($"Account Number: {RecordFields[0]}");
                Console.WriteLine($"First Name: {RecordFields[1]}");
                Console.WriteLine($"Last Name: {RecordFields[2]}");
                Console.WriteLine($"Balance: {RecordFields[3]}\n");
            }
            else
            {
                Console.WriteLine("Record not found\n");
            }         
        }

        public static void Edit_Record()
        {
            Console.WriteLine($"There is {Records.Length} record in the file");
            Console.Write("Enter record number to edit: ");
            int RecordNumber = int.Parse(Console.ReadLine());
            
            if(RecordNumber > 0 && RecordNumber <= Records.Length)
            {
                Console.WriteLine($"Record {RecordNumber} has following data");

                string[] RecordFields = Records[RecordNumber - 1].Split(',');
                Console.WriteLine($"Account Number: {RecordFields[0]}");
                Console.WriteLine($"First Name: {RecordFields[1]}");
                Console.WriteLine($"Last Name: {RecordFields[2]}");
                Console.WriteLine($"Balance: {RecordFields[3]}");
                Console.WriteLine("---------------------------- \n");

                Console.WriteLine("Enter data to modify");
                Console.Write("Enter Account Number: ");
                RecordFields[0] = Console.ReadLine();
                Console.Write("Enter First Name: ");
                RecordFields[1] = Console.ReadLine();
                Console.Write("Enter Last Name: ");
                RecordFields[2] = Console.ReadLine();
                Console.Write("Enter Balance: ");
                RecordFields[3] = Console.ReadLine();

                string strRecord = string.Join(",", RecordFields);
                Records[RecordNumber - 1] = strRecord;
                File.WriteAllLines($"{FilePath}", Records);

                Console.WriteLine("Record updated successfully\n");
            }
            else
            {
                Console.WriteLine("Record not found\n");
            }
        }

        public static void Delete_Record()
        {
            Console.WriteLine($"There is {Records.Length} record in the file");
            Console.Write("Enter record number to delete: ");
            int RecordNumber = int.Parse(Console.ReadLine());           
            
            if (RecordNumber > 0 && RecordNumber <= Records.Length)
            {
                string[] NewRecords = new string[Records.Length - 1];
                for (int i = 0; i < Records.Length; i++)
                {
                    if (i == RecordNumber - 1)
                        continue;
                    NewRecords[i] = Records[i];
                }

                File.WriteAllLines($"{FilePath}", NewRecords);
                Console.WriteLine("Record deleted successfully\n");
            }
            else
            {
                Console.WriteLine("Record not found\n");
            }            
        }

    }
}
