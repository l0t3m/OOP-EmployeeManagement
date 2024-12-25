using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Task1
{
    public class Developer : Employee
    {
        private int numberOfProjects;

        public int NumberOfProjects
        {
            get { return numberOfProjects; }
            set { numberOfProjects = value; }
        }

        public Developer(string name, int id, double baseSalary, int numberOfProjects) : base(name, id, baseSalary) 
        {
            this.numberOfProjects = numberOfProjects;
        }

        public void PrintDeveloperDetails()
        {
            Console.WriteLine($"{this.Name} (ID {this.Id}) \t Base Salary: {this.BaseSalary} \t Projects: {this.numberOfProjects}");
        }
    }
}
