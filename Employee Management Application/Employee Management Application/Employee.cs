using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee_Management_Application
{
    internal abstract class Employee : StaffMember
    {
        public Employee(int ssn , int id, string name, int phone, string email, int department_Id, string department_Name) : base(id, name, phone, email, department_Id, department_Name)
        {
            this.SSN = ssn;
        }

        private int SSN { get; set; }   
        
        public override void Print()
        {
            Console.WriteLine($"SSN: {SSN}");
            base.Print();           
        }

        public override string GetData()
        {
            return $"{SSN}" + base.GetData(); ;
        }

        public override double pay() { return 0; }
        
    }
}
