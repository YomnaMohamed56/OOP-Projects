using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee_Management_Application
{
    internal class Project
    {
        public int id { get; set; }
        private string location { get; set; }
        private decimal currentCost { get; set; }
        private Employee manager { get; set; }

        private List<Budget> budgetsList { get; set; }

        public Project(int id, string location, decimal currentCost, Employee manager)
        {
            this.id = id;
            this.location = location;
            this.currentCost = currentCost;
            this.manager = manager;
            this.budgetsList = new List<Budget>();
        }

        public void AddBudget(Budget b)
        {
            budgetsList.Add(b);
        }

        public double GetTotalBudget()
        {
            double totalBudget = 0;
            foreach(Budget b in budgetsList)
            {
                totalBudget += b.Value;
            }
            return totalBudget;
        }

        public void Print()
        {
            Console.WriteLine($"Project id: {id}");
            Console.WriteLine($"Project location: {location}");
            Console.WriteLine($"Project current cost: {currentCost}");
            Console.WriteLine("Manager information:");
            manager.Print();
            Console.WriteLine("List of budgets: ");
            if (budgetsList.Count > 0)
            {             
                int i = 0;
                foreach (Budget budget in budgetsList)
                {
                    i++;
                    Console.WriteLine($"Budget number {i}:");
                    Console.WriteLine($"       Budget id: {budget.Id}");
                    Console.WriteLine($"       Budget value: {budget.Value}");
                    Console.WriteLine("---------");
                }
            }
            else
            {
                Console.WriteLine("       There is no budget in the list");
            }
        }
    }
}
