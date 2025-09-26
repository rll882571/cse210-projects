using System;
using System.Collections.Generic;
using System.Linq;



public class Program
{
    public static void Main(string[] args)
    {
        

        Reference reference = new Reference("John", 3, 16); 

        


       
        List<Scripture> availableScriptures = new List<Scripture>();

        

        Reference ref1 = new Reference("John", 3, 16); 
        string text1 = "For God so loved the world, that he gave his only begotten Son, that whosoever believeth in him should not perish, but have everlasting life.";
        availableScriptures.Add(new Scripture(ref1, text1));

        
        Reference ref2 = new Reference("1 Nephi", 3, 7); 
        string text2 = "And it came to pass that I, Nephi, said unto my father: I will go and do the things which the Lord hath commanded, for I know that the Lord giveth no commandments unto the children of men save he shall prepare a way for them that they may accomplish the thing which he commandeth them.";
        availableScriptures.Add(new Scripture(ref2, text2));

        
        bool keepRunning = true;
        while (keepRunning)
        {
            
            Console.Clear();
            Console.WriteLine("--- Scripture Memorizer Game ---");
            Console.WriteLine("Please select a scripture to memorize:");

            
            for (int i = 0; i < availableScriptures.Count; i++)
            {
                
                Console.WriteLine($"{i + 1}) {availableScriptures[i].Reference.GetDisplayText()}");
            }

            Console.WriteLine("Type 'quit' to exit the application.");
            Console.Write("Enter your choice (1 or 2): ");
            
            string menuInput = Console.ReadLine().ToLower();

            if (menuInput == "quit")
            {
                keepRunning = false;
                break; 
            }

            
            if (int.TryParse(menuInput, out int choiceIndex) && choiceIndex >= 1 && choiceIndex <= availableScriptures.Count)
            {
                
                Scripture selectedScripture = availableScriptures[choiceIndex - 1];

                
                RunGameLoop(selectedScripture);

                
                Console.WriteLine("\n--- Game Over ---");
                Console.WriteLine("What would you like to do next?");
                Console.WriteLine("1) Choose another scripture");
                Console.WriteLine("2) Quit application");
                Console.Write("Enter your choice (1 or 2): ");

                string postGameInput = Console.ReadLine();
                if (postGameInput != "1")
                {
                    keepRunning = false; // Se não for 1, encerra
                }
            }
            else
            {
                Console.WriteLine("\nInvalid choice. Press Enter to try again.");
                Console.ReadLine();
            }
        }

        Console.WriteLine("\nThank you for playing. Goodbye!");
    }

    
    public static void RunGameLoop(Scripture scripture)
    {
        string userInput = "";
        
       
        while (userInput.ToLower() != "quit" && !scripture.IsCompletelyHidden())
        {
            
        
        Scripture scripture = new Scripture(reference, scriptureText);

        
        string userInput = "";

        
        while (userInput.ToLower() != "quit" && !scripture.IsCompletelyHidden())
        {
            

            Console.Clear();

            
            Console.WriteLine(scripture.GetDisplayText());

            // Solicita a entrada do usuário
            Console.WriteLine("\nPress Enter to hide more words or type 'quit' to end the current scripture:");
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
            // Caso o usuário tenha digitado 'quit'
            Console.WriteLine("Program ended by user.");
        }

    }
}