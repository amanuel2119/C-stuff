using System;

class Program
{
    static void Main()
    {
        // Prompt the user to enter a string
        Console.Write("Enter a string: ");
        string inputString = Console.ReadLine();
        
        // Convert the string to uppercase
        string upperCaseString = inputString.ToUpper();
        
        // Convert the string to lowercase
        string lowerCaseString = inputString.ToLower();
        
        // Display the converted strings
        Console.WriteLine("Uppercase: " + upperCaseString);
        Console.WriteLine("Lowercase: " + lowerCaseString);
    }
}
