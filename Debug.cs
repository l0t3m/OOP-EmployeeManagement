using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Task1
{
    public static class DebugHelp
    {
        static string[] names = { "Lotem", "Tohar", "Gabi", "Suzy", "Employee" };


        public static Developer CreateDebugDeveloper()
        {
            Random random = new Random();
            string name = names[random.Next(names.Length)];
            int id = random.Next(10000000, 99999999);
            int salary = random.Next(18000, 20000);
            int projects = random.Next(10, 50);
            return new Developer(name, id, salary, projects);
        }

        public static Manager CreateDebugManager()
        {
            Random random = new Random();
            string name = names[random.Next(names.Length)];
            int id = random.Next(10000000, 99999999);
            int salary = random.Next(20000, 22000);
            int teamSize = random.Next(1, 5);
            return new Manager(name, id, salary, teamSize);
        }
    }
}
