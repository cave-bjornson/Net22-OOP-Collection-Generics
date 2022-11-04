namespace ConsoleApp
{
    public class Program
    {
        public static void Main(string[] args)
        {
            void PrintDashes() => Console.WriteLine(new string('-', 64));

            var employees = new Employee[]
            {
                new(101, "Nigella Pancakes", Gender.Female, 55678M),
                new(6969, "Grave McDave", Gender.Male, 12345.6M),
                new(1138, "Peppermint Patty", Gender.Female, 459023.69M),
                new(666, "Neon White", Gender.Male, 666666.666M),
                new(345, "Meg", Gender.Female, 987654.321M)
            };

            //Part 1
            Console.WriteLine("Part 1 - Stack");
            var employeeStack = new Stack<Employee>();
            foreach (Employee e in employees)
            {
                employeeStack.Push(e);
            }

            Console.WriteLine("Print all elements in stack before popping.");
            foreach (Employee e in employeeStack)
            {
                Console.WriteLine(e);
                Console.WriteLine($"Items left in stack: {employeeStack.Count}");
            }

            PrintDashes();
            System.Console.WriteLine(
                "Pop all elements in stack and print each element removed by each pop-operation."
            );
            while (employeeStack.Count > 0)
            {
                Console.WriteLine(employeeStack.Pop());
                Console.WriteLine($"Items left in stack: {employeeStack.Count}");
            }

            // Repopulate stack for next demonstration
            foreach (Employee e in employees)
            {
                employeeStack.Push(e);
            }

            PrintDashes();
            Console.WriteLine("Peek method will not remove top of stack.");
            Console.WriteLine(employeeStack.Peek());
            Console.WriteLine($"Items left in stack: {employeeStack.Count}");
            Console.WriteLine(employeeStack.Peek());
            Console.WriteLine($"Items left in stack: {employeeStack.Count}");

            Employee e3 = employees[2];
            PrintDashes();
            Console.WriteLine("Test List.Contains on the 3rd Employee object.");
            Console.WriteLine(
                $"Employee 3 is {(employeeStack.Contains(e3) ? string.Empty : "not")}in stack"
            );
            Console.WriteLine();

            // Part 2
            Console.WriteLine("Part 2 - List");
            var employeeList = new List<Employee>(employees);
            Employee e2 = employees[1];

            PrintDashes();
            Console.WriteLine("Check if the list contains the 2nd Employee object.");
            Console.WriteLine(
                $"Employee 2 is{(employeeList.Contains(e2) ? string.Empty : " not")} present in the list"
            );

            PrintDashes();
            Console.WriteLine("Get the first male in the list.");
            Console.WriteLine("First employee in list of male gender:");
            Console.WriteLine(employeeList.Find(e => e.Gender == Gender.Male));

            PrintDashes();
            Console.WriteLine("Get all males in the list.");
            Console.WriteLine("All employees in list of male gender:");
            employeeList.FindAll(e => e.Gender == Gender.Male).ForEach(Console.WriteLine);
        }
    }
}
