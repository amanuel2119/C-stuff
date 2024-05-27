using System;

class Program
{
    static void Main(string[] args)
    {
        // Prompting user to enter time in 24-hour format
        Console.Write("Enter time in 24-hour format (hh:mm:ss): ");
        string inputTime = Console.ReadLine();

        // Attempting to parse input time
        if (DateTime.TryParseExact(inputTime, "HH:mm:ss", null, System.Globalization.DateTimeStyles.None, out DateTime parsedTime))
        {
            // Successfully parsed, converting to 12-hour format
            string outputTime = parsedTime.ToString("hh:mm:ss tt");
            Console.WriteLine($"Time in 12-hour format: {outputTime}");
        }
        else
        {
            // Parsing error, displaying error message
            Console.WriteLine("Invalid time format. Please enter time in the format hh:mm:ss.");
        }
    }
}