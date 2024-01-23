using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Bus_Reservation_System_Project
{
    internal class Bus_System
    {
        private const string BusesInformationFilePath = "D:\\Study\\OOP Projects\\Bus Reservation System Project\\Buses_Information_Records_File.txt";
        private const string BusesReservationFilePath = "D:\\Study\\OOP Projects\\Bus Reservation System Project\\Buses_Reservation_Records_File.txt";
        private static string[] Buses_Information_Records = File.ReadAllLines(BusesInformationFilePath);
        private static string[] Buses_Reservation_Records = File.ReadAllLines(BusesReservationFilePath);

        public static void Install_Bus()
        {
            Console.Write("Enter bus no: ");
            int BusNumber = int.Parse(Console.ReadLine());
            Console.Write("Enter driver name: ");
            string DriverName = Console.ReadLine();
            Console.Write("Arrivala time: ");
            string ArrivalaTime = Console.ReadLine();
            Console.Write("Departure time: ");
            string DepartureTime = Console.ReadLine();
            Console.Write("From: "); 
            string destination_From = Console.ReadLine();
            Console.Write("To: ");
            string destination_To = Console.ReadLine();

            StreamWriter sw = new StreamWriter(BusesInformationFilePath, true);
            sw.WriteLine($"{BusNumber},{DriverName},{ArrivalaTime},{DepartureTime},{destination_From},{destination_To}");
            sw.Close();

            Console.WriteLine("Bus installed successfully");
            Console.WriteLine("---------------------------------------\n");
        }

        public static void Reservation()
        {
            //receive reservation data from user
            Console.Write("Enter bus no: ");
            int BusNumber = int.Parse(Console.ReadLine());
            Console.Write("Enter seat number: ");
            int SeatNumber = int.Parse(Console.ReadLine());
            Console.Write("Enter passenger name: ");
            string PassengerName = Console.ReadLine();

            //create Buses_Reservation_Records_File
            StreamWriter sw = new StreamWriter(BusesReservationFilePath, true);
            sw.Close();

            //check if bus number is found in Buses_Information_Records_File
            foreach(string Record in Buses_Information_Records)
            {
                string[] BusFields = Record.Split(',');
                if (BusFields[0] == BusNumber.ToString())
                {
                    //check if Buses_Reservation_Records_File is empty
                    if (File.ReadAllText(BusesReservationFilePath) == null)
                    {
                        Install_Bus_Reservation(BusNumber, SeatNumber, PassengerName);                 
                        return;
                    }

                    //check if seat number is available for reservation in Buses_Reservation_Records_File
                    foreach (string record in Buses_Reservation_Records)
                    {
                        string[] ReservationFields = record.Split(',');
                        if (ReservationFields[1] == SeatNumber.ToString())
                        {
                            Console.WriteLine("Seat doesn't available. The seat is already reserved");
                            Console.WriteLine("---------------------------------------\n");
                            return;
                        }
                    }

                    Install_Bus_Reservation(BusNumber, SeatNumber, PassengerName);
                    return;
                } 
            }

            //if Bus number given by user not found
            Console.WriteLine("Bus not Found");
            Console.WriteLine("---------------------------------------\n");
        }

        private static void Install_Bus_Reservation(int BusNumber, int SeatNumber, string PassengerName)
        {
            StreamWriter sw = new StreamWriter(BusesReservationFilePath, true);
            sw.WriteLine($"{BusNumber},{SeatNumber},{PassengerName}");
            sw.Close();
            Console.WriteLine("Reservation done successfully");
            Console.WriteLine("---------------------------------------\n");
        }
    
        public static void Show()
        {
            Console.Write("Enter bus no: ");
            int BusNumber = int.Parse(Console.ReadLine());
            Console.WriteLine("**************************************************************");

            //search for the bus number in Buses_Information_Records_File
            foreach(string Record in Buses_Information_Records)
            {
                string[] RecordFields = Record.Split(',');
                if (RecordFields[0] == BusNumber.ToString())
                {
                    Console.WriteLine($"Bus no:             {RecordFields[0]}");
                    Console.WriteLine($"Deriver:            {RecordFields[1]}");
                    Console.WriteLine($"Arrival time:       {RecordFields[2]}");
                    Console.WriteLine($"Departure time:     {RecordFields[3]}");
                    Console.WriteLine($"From:               {RecordFields[4]}");
                    Console.WriteLine($"To:                 {RecordFields[5]}");
                    Console.WriteLine("**************************************************************");
                    break;
                }
            }

            //check for reserved and empty seats in the given bus at Buses_Reservation_Records_File
            string[] BusSeats = new string[32];
            
            //check for reserved seats
            foreach(string Record in Buses_Reservation_Records)
            {
                string[] RecordFields = Record.Split(',');
                if (RecordFields[0] == BusNumber.ToString())
                {
                    int seatnum = int.Parse(RecordFields[1]);
                    BusSeats[seatnum-1] = RecordFields[2];
                }
            }

            //check for empty seats
            int EmptySeatsNumber = 0;
            for(int i = 0; i < 32; i++)
            {
                if (BusSeats[i] == null)
                {
                    BusSeats[i] = "Empty";
                    EmptySeatsNumber++;
                }
            }

            //print all seats
            for(int i = 1; i <= 32; i += 4)
            {
                int j = i - 1;
                Console.WriteLine($"{i}- {BusSeats[j]}   {i + 1}- {BusSeats[j + 1]}   {i + 2}- {BusSeats[j + 2]}   {i + 3}- {BusSeats[j + 3]}");
            }

            Console.WriteLine();
            Console.WriteLine($"There is {EmptySeatsNumber} seats empty in bus No: {BusNumber}");
            
            for(int i = 0; i < BusSeats.Length; i++)
            {
                if(BusSeats[i] != "Empty")
                {
                    Console.WriteLine($"The seat no {i+1} is reserved for {BusSeats[i]}");
                }
            }

            Console.WriteLine("---------------------------------------\n");
        }

        public static void Buses_Available()
        {
            foreach(string Record in Buses_Information_Records)
            {
                string[] RecordFields = Record.Split(',');
                Console.WriteLine($"Bus No {RecordFields[0]} is available");
            }
            Console.WriteLine("---------------------------------------\n");
        }
    }
}
