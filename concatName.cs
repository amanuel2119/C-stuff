using System;

class Program
{
    static void Main()
    {
        // Prompt the user to enter their first name
        Console.Write("Enter your first name: ");
        string firstName = Console.ReadLine();
        
        // Prompt the user to enter their last name
        Console.Write("Enter your last name: ");
        string lastName = Console.ReadLine();
        
        // Concatenate the first and last name
        string fullName = firstName + " " + lastName;
        
        // Display the full name
        Console.WriteLine("Your full name is: " + fullName);
    }
}
