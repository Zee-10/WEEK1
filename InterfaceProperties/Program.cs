namespace InterfaceProperties
{

    interface IEmployee
    {
        // Property declarations
        string Name { get; set; }
        int Age { get; set; }

        // Method declaration
        void Work();
    }

    // Implement the interface in a class
    class Employee : IEmployee
    {
        // Implement the properties
        public string Name { get; set; }
        public int Age { get; set; }

        // Implement the method
        public void Work()
        {
            Console.WriteLine($"{Name} is working.");
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            // Create an instance of the implementing class
            IEmployee employee = new Employee
            {
                Name = "Alice",
                Age = 30
            };

            // Use the interface properties and method
            Console.WriteLine($"Employee Name: {employee.Name}");
            Console.WriteLine($"Employee Age: {employee.Age}");
            employee.Work();
        }
    }
}
