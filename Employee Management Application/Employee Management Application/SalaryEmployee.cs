using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee_Management_Application
{
    internal class SalaryEmployee : Employee
    {
        private double salary { get; set; }
        public SalaryEmployee(double _salary, int ssn, int id, string name, int phone, string email, int department_Id, string department_Name) : base(ssn, id, name, phone, email, department_Id, department_Name)
        {
            this.salary = _salary;
        }

        public override double pay()
        {
            return salary;
        }

        public override void Print()
        {
            base.Print();
            Console.WriteLine($"Employee salary: {salary}");
        }
    }
}
