using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee_Management_Application
{
    internal abstract class StaffMember : Department
    {
        public StaffMember(int id, string name, int phone, string email, int department_Id, string department_Name) : base(department_Id, department_Name)
        {
            this.Id = id;
            this.Name = name;
            this.Phone = phone;
            this.Email = email;
        }

        private int Id { get; set; }
        private string Name { get; set; }
        private int Phone { get; set; }
        private string Email { get; set; }

        public override void Print()
        {
            Console.WriteLine($"id: {Id}");
            Console.WriteLine($"name: {Name}");
            Console.WriteLine($"phone: {Phone}");
            Console.WriteLine($"email: {Email}");
            base.Print();
        }

        public override string GetData()
        {
            return $"{Id},{Name},{Phone},{Email}," + base.GetData(); 
        }

        public abstract double pay();
        
    }
}
