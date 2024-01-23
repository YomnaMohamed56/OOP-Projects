using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Intrinsics.X86;
using System.Text;
using System.Threading.Tasks;

namespace Employee_Management_Application
{
    internal class HourlyEmployee : Employee
    {
        private double rate { get; set; }
        private double hours { get; set; }

        public HourlyEmployee(double _rate, double _hours, int ssn, int id, string name, int phone, string email, int department_Id, string department_Name): base(ssn, id, name, phone, email, department_Id, department_Name)
        {
            this.rate = _rate;
            this.hours = _hours;
        }

        public override double pay()
        {
            return rate * hours;
        }

        public override void Print()
        {
            base.Print();
            Console.WriteLine($"Employee rate: {rate}");
            Console.WriteLine($"Employee hours: {hours}");
        }
    }
}
