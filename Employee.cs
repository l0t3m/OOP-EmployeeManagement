using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    public class Employee
    {
        private string name;
        private int id;
        private double baseSalary;

        public string Name 
        { 
            get { return name; } 
            set { name = value; } 
        }

        public int Id 
        { 
            get { return id; } 
            set { id = value; } 
        }

        public double BaseSalary 
        { 
            get { return baseSalary; } 
            set { baseSalary = value; } 
        }

        public Employee(string name, int id, double baseSalary) 
        {
            this.name = name;
            this.id = id;
            this.baseSalary = baseSalary;
        }
    }
}
