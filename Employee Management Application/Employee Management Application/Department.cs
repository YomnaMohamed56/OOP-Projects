using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee_Management_Application
{
    internal class Department
    {
        public Department(int department_Id, string department_Name)
        {
            this.Department_Id = department_Id;
            this.Department_Name = department_Name;
        }

        protected int Department_Id { get; set; }
        protected string Department_Name { get; set; }

        public virtual void Print()
        {
            Console.WriteLine($"Department id: {Department_Id}");
            Console.WriteLine($"Department name: {Department_Name}");
        }

        public virtual string GetData()
        {
            return $"{Department_Id},{Department_Name}";
        }
    }
}
