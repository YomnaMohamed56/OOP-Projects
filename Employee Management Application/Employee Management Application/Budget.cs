using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee_Management_Application
{
    internal class Budget
    {
        public int Id { get; set; }
        public double Value { get; set; }

        public Budget(int id, double value)
        {
            Id = id;
            Value = value;
        }

        public void increaseBudget(double value)
        {
            this.Value += value;
        }
    }
}
