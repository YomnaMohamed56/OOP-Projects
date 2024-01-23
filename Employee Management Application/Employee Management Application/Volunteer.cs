using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Intrinsics.X86;
using System.Text;
using System.Threading.Tasks;

namespace Employee_Management_Application
{
    internal class Volunteer : StaffMember
    {
        public Volunteer(double _AmountOfValue, int id, string name, int phone, string email, int department_Id, string department_Name) : base(id, name, phone, email, department_Id, department_Name)
        {
            this.AmountOfValue = _AmountOfValue;
        }
        
        private double AmountOfValue { get; set; }

        public override void Print()
        {
            base.Print();
            Console.WriteLine($"Amount of value: {AmountOfValue}");
        }

        public override double pay() { return AmountOfValue; }

        public override string GetData()
        {
            return $"{AmountOfValue}" + base.GetData(); ;
        }
    }
}
