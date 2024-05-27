using System;

class Program
{
    static void Main()
    {
        // Prompt the user to enter a sentence
        Console.Write("Enter a sentence: ");
        string sentence = Console.ReadLine();
        
        // Prompt the user to enter the word to replace
        Console.Write("Enter the word to replace: ");
        string wordToReplace = Console.ReadLine();
        
        // Prompt the user to enter the replacement word
        Console.Write("Enter the replacement word: ");
        string replacementWord = Console.ReadLine();
        
        // Replace all occurrences of the word in the sentence
        string modifiedSentence = sentence.Replace(wordToReplace, replacementWord);
        
        // Display the modified sentence
        Console.WriteLine("Modified sentence: " + modifiedSentence);
    }
}
