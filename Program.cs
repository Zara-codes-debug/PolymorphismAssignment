using System;

// Define an interface called IQuittable
public interface IQuittable
{
    // Declare a void method called Quit()
    void Quit();
}

// Employee class inherits from IQuittable
public class Employee : IQuittable
{
    public string Name { get; set; }

    // Implement the Quit() method
    public void Quit()
    {
        // Display a message when the employee quits
        Console.WriteLine($"{Name} has quit the job.");
    }
}

class Program
{
    static void Main(string[] args)
    {
        // Create an Employee object and set its Name
        Employee emp = new Employee() { Name = "Farzana" };

        // Use polymorphism: assign Employee object to IQuittable type
        IQuittable quittable = emp;

        // Call the Quit() method via the interface reference
        quittable.Quit();

        // Keep console open until user presses Enter
        Console.ReadLine();
    }
}
