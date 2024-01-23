using System;
using System.Collections;
using System.Runtime.CompilerServices;

namespace Employee_Management_Application
{
    internal class Program
    {
        static void Main(string[] args)
        {
                                    /////////// 1- department ///////////
            //Add Departments
            Department D1 = new Department(1, "Sales");
            Department D2 = new Department(2, "Marketing");
            Department D3 = new Department(3, "IT");

            //Print All Departments
            Console.WriteLine("All Departments:");
            D1.Print();
            Console.WriteLine("--------");
            D2.Print();
            Console.WriteLine("--------");
            D3.Print();                        
            Console.WriteLine("================================================");



                                   /////////// 2- Staff ///////////
            //Create Employees
            Employee E1 = new HourlyEmployee(1200, 8, 12345, 111, "Yomna", 01234567890, "yomna@gmail.com", 1, "Sales");
            Employee E2 = new SalaryEmployee(5000, 54321, 222, "Laila", 01123456789, "laila@yahoo.com", 2, "Marketing");
            Employee E3 = new ExecutiveEmployee(1000, 7500, 67890, 333, "Fayroz", 0102345678, "fayroz@gmail.com", 3, "IT");
            Employee E4 = new CommissionEmployee(3000, 98765, 444, "Rody", 01523456789, "rody@yahoo.com", 2, "Marketing");

            //Create Volunteer
            Volunteer V1 = new Volunteer(4200, 555, "Dalida", 01209876543, "dalida@gmail.com", 1, "Sales");

            //create Staff Object
            Staff staff = new Staff();

            //Add Staff Members (Employees/Volunteer)
            staff.Add(E1);
            staff.Add(E2);
            staff.Add(E3);
            staff.Add(E4);
            staff.Add(V1);

            //Show All Staff Members
            Console.WriteLine("All staff members:");
            staff.ShowAll();
            Console.WriteLine("================================================");

            //Calculate payroll for each member
            Console.WriteLine("Payroll for each member:");
            Console.WriteLine($"Payroll for member 1: {E1.pay()}");
            Console.WriteLine($"Payroll for member 2: {E2.pay()}");
            Console.WriteLine($"Payroll for member 3: {E3.pay()}");
            Console.WriteLine($"Payroll for member 4: {E4.pay()}");
            Console.WriteLine($"Payroll for member 5: {V1.pay()}");
            Console.WriteLine("================================================");

            //Calculate total payment for all members
            Console.WriteLine("Total payment:");
            staff.callPayroll();
            Console.WriteLine("================================================");

            //Search for memmbers in 'Markiting' department
            Console.WriteLine("Memmbers in 'Marketing' department:");
            staff.Search("Marketing");
            Console.WriteLine("================================================");

            //Delete member
            staff.Delete(2);

            //show all members again after deletion
            Console.WriteLine("All staff member after delete member number 3:");
            staff.ShowAll();
            Console.WriteLine("================================================");

            //Edite member
            Employee E5 = new SalaryEmployee(5000, 54321, 222, "Laila", 01123456789, "laila@yahoo.com", 2, "IT");
            staff.Edit(1, E5);

            //show all members again after modification
            Console.WriteLine("All staff member after Edit member number 2:");
            staff.ShowAll();
            Console.WriteLine("================================================");



                                 /////////// 3- Project ///////////
            //Add Projects
            Project P1 = new Project(1, "Cairo", 5000, E1);
            Project P2 = new Project(2, "Alex", 8000, E2);

            //Print All Projects
            Console.WriteLine("All projects:");
            P1.Print();
            Console.WriteLine("--------");
            P2.Print();
            Console.WriteLine("================================================");

            //Create Budget object
            Budget B1 = new Budget(1, 10000);
            Budget B2 = new Budget(2, 5000); 

            //Increase Budget
            B1.increaseBudget(500);

            //Add budget to Existing Project
            P1.AddBudget(B1);
            P1.AddBudget(B2);

            //Get total budget for project p1
            Console.WriteLine($"Total Budget For Project P1: {P1.GetTotalBudget()}");
            Console.WriteLine("================================================");

            //Print Project 1 after add budget
            Console.WriteLine("Project 1 after add budget:");
            P1.Print();
        }
    }
}