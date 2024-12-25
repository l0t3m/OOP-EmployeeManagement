namespace Task1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the maximum number of developers: ");
            int devAmount = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the maximum number of managers: ");
            int manAmount = int.Parse(Console.ReadLine());
            Company myCompany = new Company(devAmount, manAmount);

            while (true)
            {
                Console.Clear();
                myCompany.PrintCompany();
                MenuManager.PrintMenu();

                Console.Write("Choose an option: ");
                string choice = Console.ReadLine();
                Console.Clear();

                switch (choice)
                {
                    case "1":
                        if (myCompany.CanAddDev())
                            myCompany.AddDeveloper(MenuManager.Handle_AddDev());
                        else
                            Console.WriteLine("Cannot add more developers. Maximum capacity reached.");
                        Console.ReadLine();
                        break;
                    case "2":
                        if (myCompany.CanAddManager())
                            myCompany.AddManager(MenuManager.Handle_AddManager());
                        else
                            Console.WriteLine("Cannot add more managers. Maximum capacity reached.");
                        Console.ReadLine();
                        break;
                    case "3":
                        myCompany.PrintEmployees();
                        Console.ReadLine();
                        break;
                    case "4":
                        Console.WriteLine("Program ended.");
                        Console.ReadLine();
                        Environment.Exit(0);
                        break;
                    case "5":
                        myCompany.AddDeveloper(DebugHelp.CreateDebugDeveloper());
                        break;
                    case "6":
                        myCompany.AddManager(DebugHelp.CreateDebugManager());
                        break;
                }
            }
        }
    }
}
