using System.Security.Cryptography.X509Certificates;

namespace EmployeRegistry
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool displayMenu = true;
            while (displayMenu)
            {
                displayMenu = MainMenu();
            }
        }

        private static bool MainMenu()
        {
            Console.Clear();
            Console.WriteLine("Välj bland följande:");
            Console.WriteLine("1) Lägg till anställd till registret");
            Console.WriteLine("2) Skriv ut anställningsregistret i helhet på skärmen");
            Console.WriteLine("3) Avsluta");
            string result = Console.ReadLine();
            if (result == "1")
            {
                AddEmployee();
                return true;
            }
            else if (result == "2")
            {
                PrintRegistry();
                return true;
            }
            else if (result == "3")
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        private static void AddEmployee()
        {
            Console.Clear();
            Employee employee = new Employee();

            Console.WriteLine("Förnamn: ");
            employee.firstName = Console.ReadLine();

            Console.WriteLine("Efternamn: ");
            employee.lastName = Console.ReadLine();

            Console.WriteLine("Lön: ")
            employee.salary = Convert.ToInt32(Console.ReadLine());
        }

        private static void PrintRegistry()
        {

        }
    }

    internal class Employee
    {
        public string firstName;
        public string lastName;
        public int salary;
    }
}
