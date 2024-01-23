using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Intrinsics.X86;
using System.Text;
using System.Threading.Tasks;

namespace Employee_Management_Application
{
    internal class ExecutiveEmployee : SalaryEmployee
    {
        private double bonus { get; set; }

        public ExecutiveEmployee(double _bonus, double salary, int ssn, int id, string name, int phone, string email, int department_Id, string department_Name) : base(salary, ssn, id, name, phone, email, department_Id, department_Name)
        {
            this.bonus = _bonus;
        }

        public override double pay()
        {
            return base.pay() + bonus;
        }

        public override void Print()
        {
            base.Print();
            Console.WriteLine($"Employee bonus: {bonus}");
        }
    }
}
