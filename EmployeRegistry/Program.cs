using System.Security.Cryptography.X509Certificates;
/*
    1. Vilka klasser bör ingå i programmet?
    Svar: En: Employee

    2. Vilka attribut och metoder bör ingå i dessa klasser?
    Svar: 3 atribut (förnamn, efternamn och lön) och 2 metoder (en för inmatning, en för registerutskrift). 
 */


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
                Employee.AddEmployee();
                return true;
            }
            else if (result == "2")
            {
                Employee.PrintRegistry();
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
    }

    internal class Employee
    {
        public string firstName;
        public string lastName;
        public int salary;

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
}
