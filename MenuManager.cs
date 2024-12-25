using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    public static class MenuManager
    {
        public static void PrintMenu()
        {
            Console.WriteLine("Choose an option:");
            Console.WriteLine("1 - Add a developer");
            Console.WriteLine("2 - Add a manager");
            Console.WriteLine("3 - Print all employees");
            Console.WriteLine("4 - Exit the program");
        }

        public static Developer Handle_AddDev() // Handles option 1
        {
            Console.Write("Name: ");
            string name = Console.ReadLine();

            Console.Write("ID: ");
            int id = int.Parse(Console.ReadLine());

            Console.Write("Base Salary: ");
            int baseSalary = int.Parse(Console.ReadLine());

            Console.Write("Projects Completed: ");
            int projects = int.Parse(Console.ReadLine());

            return new Developer(name, id, baseSalary, projects);
        }

        public static Manager Handle_AddManager() // Handles option 2
        {
            Console.Write("Name: ");
            string name = Console.ReadLine();

            Console.Write("ID: ");
            int id = int.Parse(Console.ReadLine());

            Console.Write("Base Salary: ");
            int baseSalary = int.Parse(Console.ReadLine());

            Console.Write("Team Size: ");
            int teamSize = int.Parse(Console.ReadLine());

            return new Manager(name, id, baseSalary, teamSize);
        }
    }
}
