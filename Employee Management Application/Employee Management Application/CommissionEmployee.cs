using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee_Management_Application
{
    internal class CommissionEmployee : Employee
    {
        private double target { get; set; }
        
        public CommissionEmployee(double _target, int ssn, int id, string name, int phone, string email, int department_Id, string department_Name) : base(ssn, id, name, phone, email, department_Id, department_Name)
        {
            this.target = _target;
        }

        public override double pay()
        {
            return (0.05) * target;
        }

        public override void Print()
        {
            base.Print();
            Console.WriteLine($"Employee target: {target}");
        }
    }
}
