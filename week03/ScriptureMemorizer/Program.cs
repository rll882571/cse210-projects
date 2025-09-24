using System;

public class Program
{
    public static void Main(string[] args)
    {
        
        Reference reference = new Reference("John", 3, 16); 

        

        string scriptureText = "For God so loved the world, that he gave his only begotten Son, that whosoever believeth in him should not perish, but have everlasting life.";
        
        
        Scripture scripture = new Scripture(reference, scriptureText);

        
        string userInput = "";

        
        while (userInput.ToLower() != "quit" && !scripture.IsCompletelyHidden())
        {
            /
            Console.Clear();

            
            Console.WriteLine(scripture.GetDisplayText());

            // Solicita a entrada do usuário
            Console.WriteLine("\nPress Enter to continue or type 'quit' to end:");
            userInput = Console.ReadLine();

            
            if (userInput.ToLower() != "quit")
            {
                
                scripture.HideRandomWords(3);
            }
        }

        
        if (scripture.IsCompletelyHidden())
        {
            Console.Clear();
            Console.WriteLine(scripture.GetDisplayText());
            Console.WriteLine("\nAll words are hidden. Program ended.");
        }
        else
        {
            
            Console.WriteLine("Program ended by user.");
        }
    }
}