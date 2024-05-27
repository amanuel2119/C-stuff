using System;

class Program
{
    static void Main(string[] args)
    {
        // Accepting user's name
        Console.Write("Enter your name: ");
        string userName = Console.ReadLine();

        // Greeting with personalized message including name and current date/time
        Console.WriteLine($"Hello, {userName}! Welcome to the Age Calculator.");
        Console.WriteLine($"Current Date and Time: {DateTime.Now}");

        // Asking user to enter their birth date
        Console.Write("Please enter your birth date (YYYY-MM-DD): ");
        DateTime birthDate;
        while (!DateTime.TryParse(Console.ReadLine(), out birthDate))
        {
            Console.WriteLine("Invalid date format. Please enter date in the format YYYY-MM-DD.");
            Console.Write("Please enter your birth date (YYYY-MM-DD): ");
        }

        // Calculating user's age
        int age = CalculateAge(birthDate, DateTime.Now);

        // Displaying user's age
        Console.WriteLine($"Your age is: {age}");
    }

    // Method to calculate age based on birth date and current date
    static int CalculateAge(DateTime birthDate, DateTime currentDate)
    {
        int age = currentDate.Year - birthDate.Year;
        
        // Subtract a year if the birth date hasn't occurred yet this year
        if (currentDate.Month < birthDate.Month || (currentDate.Month == birthDate.Month && currentDate.Day < birthDate.Day))
        {
            age--;
        }
        
        return age;
    }
}

