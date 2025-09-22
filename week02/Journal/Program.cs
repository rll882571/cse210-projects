using System;
using System.Collections.Generic;
using System.Linq;

public class Program
{
    public static void Main(string[] args)
    {
        Journal myJournal = new Journal();
        PromptGenerator promptGenerator = new PromptGenerator();
        string choice = "";

        while (choice != "5")
        {
            Console.WriteLine("Please select one of the following choices:");
            Console.WriteLine("1. Write New Entry");
            Console.WriteLine("2. Display Journal");
            Console.WriteLine("3. Save to File");
            Console.WriteLine("4. Load from File");
            Console.WriteLine("5. Quit");
            Console.WriteLine("6. Search by Tag"); // Nova opção de menu
            Console.Write("What would you like to do? ");
            choice = Console.ReadLine();

            if (choice == "1")
            {
                string prompt = promptGenerator.GetRandomPrompt();
                Console.WriteLine(prompt);
                Console.Write("> ");
                string response = Console.ReadLine();

                Entry newEntry = new Entry();
                newEntry._promptText = prompt;
                newEntry._entryText = response;
                newEntry._date = DateTime.Now.ToShortDateString();
                
                // Pede as tags ao usuário
                Console.Write("Enter tags separated by comma (e.g., travel, work, feelings): ");
                string tagsInput = Console.ReadLine();
                // Processa a string de tags e adiciona à entrada
                newEntry._tags = tagsInput.Split(',', StringSplitOptions.RemoveEmptyEntries).Select(t => t.Trim().ToLower()).ToList();

                myJournal.AddEntry(newEntry);
            }
            else if (choice == "2")
            {
                myJournal.Display();
            }
            else if (choice == "3")
            {
                Console.Write("Enter the filename to save: ");
                string filename = Console.ReadLine();
                myJournal.SaveToFile(filename);
            }
            else if (choice == "4")
            {
                Console.Write("Enter the filename to load: ");
                string filename = Console.ReadLine();
                myJournal.LoadFromFile(filename);
            }
            else if (choice == "5")
            {
                Console.WriteLine("Exiting the program. Goodbye!");
            }
            else if (choice == "6") // Lógica para a nova opção de busca
            {
                Console.Write("Enter the tag to search for: ");
                string tag = Console.ReadLine();
                myJournal.SearchByTag(tag);
            }
            else
            {
                Console.WriteLine("Invalid option. Please choose a number from 1 to 6.");
            }
        }
    }
}