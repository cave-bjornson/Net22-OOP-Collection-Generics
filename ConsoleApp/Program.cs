namespace ConsoleApp
{
    public class Program
    {
        public static void Main(string[] args)
        {
            void PrintDashes() => Console.WriteLine(new string('-', 64));
            var employees = new Employee[]
            {
                new(101, "Nigella Pancakes", Gender.Female, 55678),
                new(6969, "Grave McDave", Gender.Male, 12345.6M),
                new(1138, "Peppermint Patty", Gender.Female, 459023.69M),
                new(666, "Neon White", Gender.Male, 666666.666M),
                new(345, "Meg", Gender.Female, 987654.321M)
            };

            var employeeStack = new Stack<Employee>();
            foreach (Employee e in employees)
            {
                employeeStack.Push(e);
            }

            foreach (Employee e in employeeStack)
            {
                Console.WriteLine(e);
                Console.WriteLine($"Items left in stack: {employeeStack.Count}");
            }
            PrintDashes();
            while (employeeStack.Count > 0)
            {
                Console.WriteLine(employeeStack.Pop());
                Console.WriteLine($"Items left in stack: {employeeStack.Count}");
            }
            PrintDashes();
            foreach (Employee e in employees)
            {
                employeeStack.Push(e);
            }

            Console.WriteLine("Peek method will not remove top of stack");
            Console.WriteLine(employeeStack.Peek());
            Console.WriteLine($"Items left in stack: {employeeStack.Count}");
            Console.WriteLine(employeeStack.Peek());
            Console.WriteLine($"Items left in stack: {employeeStack.Count}");
            PrintDashes();

            Employee e3 = employees[2];
            Console.WriteLine($"Employee 3 is {(employeeStack.Contains(e3) ? "" : "not")}in stack");
            PrintDashes();
            // part 2
            var employeeList = new List<Employee>(employees);
            Employee e2 = employees[1];
            Console.WriteLine(
                $"Employee2 object {(employeeList.Contains(e2) ? "" : "does not")}exists in the list"
            );
            PrintDashes();
            Console.WriteLine(employeeList.Find(e => e.Gender == Gender.Male));
            PrintDashes();
            employeeList.FindAll(e => e.Gender == Gender.Male).ForEach(Console.WriteLine);
        }
    }
}
