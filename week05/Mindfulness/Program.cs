using System;

class Program
{
    static void Main(string[] args)
    {
        string choice = "";

        while (choice != "4")
        {
            Console.Clear(); // Limpa o console para uma nova exibição do menu.
            Console.WriteLine("Menu Options:");
            Console.WriteLine("  1. Start Breathing Activity");
            Console.WriteLine("  2. Start Reflecting Activity");
            Console.WriteLine("  3. Start Listing Activity");
            Console.WriteLine("  4. Quit");
            Console.Write("Select a choice from the menu: ");
            
            choice = Console.ReadLine();
            Console.WriteLine(); // Adiciona uma linha em branco para espaçamento.

            
            Activity currentActivity = null;

            switch (choice)
            {
                case "1":
                    currentActivity = new BreathingActivity();
                    break;
                case "2":
                    currentActivity = new ReflectingActivity();
                    break;
                case "3":
                    currentActivity = new ListingActivity();
                    break;
                case "4":
                    Console.WriteLine("Goodbye!");
                    break;
                default:
                    Console.WriteLine("Invalid choice. Please select a valid option.");
                    Thread.Sleep(2000); // Pausa para o usuário ler a mensagem.
                    break;
            }

            if (currentActivity != null)
            {
                currentActivity.Run();
            }
        }
    }
}