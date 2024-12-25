using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    public class Manager : Employee
    {
        private int teamSize;

        public int TeamSize 
        { 
            get { return teamSize; } 
            set { teamSize = value; } 
        }

        public Manager(string name, int id, double baseSalary, int teamSize) : base(name, id, baseSalary) 
        {
            this.teamSize = teamSize;
        }

        public void PrintManagerDetails()
        {
            Console.WriteLine($"{this.Name} (ID {this.Id})");
            Console.WriteLine($"   Base Salary: {this.BaseSalary}");
            Console.WriteLine($"   Team Size: {this.teamSize}");
        }
    }
}
