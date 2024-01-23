using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee_Management_Application
{
    internal class Staff
    {
        private List<StaffMember> StaffList;

        public Staff()
        {
            StaffList = new List<StaffMember>();
        }

        public int CountValue => StaffList.Count; 

        public void Add(StaffMember member)
        {
            StaffList.Add(member);
        }

        public void Edit(int index, StaffMember member)
        {
            StaffList.RemoveAt(index);
            StaffList.Insert(index, member);
        }

        public void Delete(int index)
        {
            StaffList.RemoveAt(index);
        }

        public void Search(string SearchData)
        {
            List<StaffMember> MatchedMemmber = new List<StaffMember>();
            foreach(StaffMember member in StaffList)
            {
                if (member.GetData().Contains(SearchData))
                {
                    MatchedMemmber.Add(member);
                }
            }
            
            foreach(StaffMember member in MatchedMemmber)
            {
                member.Print();
                Console.WriteLine("--------");
            }
        }

        public void ShowAll()
        {
            int i = 0;
            foreach(StaffMember member in StaffList)
            {
                i++;
                Console.WriteLine($"Member number {i}: ");
                member.Print();
                Console.WriteLine("--------");
            }
        }

        public void callPayroll()
        {
            double TotalPayment = 0;
            foreach(StaffMember member in StaffList)
            {
                TotalPayment += member.pay();
            }
            Console.WriteLine(TotalPayment);
        }

    }
}
