using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    public class Company
    {
        private int maxDevelopers;
        private int maxManagers;
        private List<Developer> developers;
        private List<Manager> managers;

        // -------------------------------------------------- //

        public int MaxDevelopers
        {
            get { return maxDevelopers; }
            set { maxDevelopers = value; }
        }

        public int MaxManagers
        {
            get { return maxManagers; }
            set { MaxManagers = value; }
        }

        public List<Developer> Developers
        {
            get { return developers; }
        }

        public List<Manager> Managers
        {
            get { return managers; }
        }

        // -------------------------------------------------- //

        public Company(int maxDev, int maxMan)
        {
            this.developers = new List<Developer>();
            this.managers = new List<Manager>();
            this.maxDevelopers = maxDev;
            this.maxManagers = maxMan;
        }

        // -------------------------------------------------- //

        public bool CanAddDev()
        {
            if (Developers.Count < this.maxDevelopers)
                return true;
            return false;
        }

        public bool CanAddManager()
        {
            if (this.managers.Count < this.maxManagers)
                return true;
            return false;
        }

        public void AddDeveloper(Developer dev)
        {
            if (CanAddDev())
            {
                developers.Add(dev);
                Console.WriteLine($"Developer {dev.Name} added successfully.");
            }
            else
                Console.WriteLine("Cannot add more developers. Maximum capacity reached.");
        }

        public void AddManager(Manager man)
        {
            if (CanAddManager())
            {
                managers.Add(man);
                Console.WriteLine($"Manager {man.Name} added successfully.");
            }
            else
                Console.WriteLine("Cannot add more managers. Maximum capacity reached.");
        }

        public void PrintEmployees()
        {
            if (developers.Count == 0 && managers.Count == 0)
            {
                Console.WriteLine("No workers yet!");
            }
            else
            {
                if (developers.Count > 0)
                {
                    Console.WriteLine("----- Developers: -----");
                    foreach (var developer in this.developers)
                    {
                        developer.PrintDeveloperDetails();
                    }
                }
                
                if (managers.Count > 0)
                {
                    Console.WriteLine("----- Managers: -----");
                    foreach (var manager in this.managers)
                    {
                        manager.PrintManagerDetails();
                    }
                }
            }
        }

        public void PrintCompany()
        {
            Console.WriteLine("----- Your Company: -----");
            Console.WriteLine($"Developers: {this.Developers.Count} / {this.MaxDevelopers}");
            Console.WriteLine($"Managers: {this.Managers.Count} / {this.MaxManagers}");
            Console.WriteLine("-------------------------\n");
        }
    }
}
