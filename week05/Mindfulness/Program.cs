using System;

// CREATIVITY - EXCEEDING REQUIREMENTS: To exceed the core requirements, I have implemented
// a session activity counter. The program now tracks how many times each activity has been
// completed during the current session. When the user quits (option 4), a summary is
// displayed, showing the user their accomplishments and encouraging continued use.
class Program
{
    // Adicionamos contadores estáticos para cada atividade.
    // 'static' significa que eles pertencem à classe Program e mantêm seu valor
    // durante toda a execução do programa.
    private static int _breathingCount = 0;
    private static int _reflectingCount = 0;
    private static int _listingCount = 0;

    static void Main(string[] args)
    {
        string choice = "";

        while (choice != "4")
        {
            Console.Clear();
            Console.WriteLine("Menu Options:");
            Console.WriteLine("  1. Start Breathing Activity");
            Console.WriteLine("  2. Start Reflecting Activity");
            Console.WriteLine("  3. Start Listing Activity");
            Console.WriteLine("  4. Quit");
            Console.Write("Select a choice from the menu: ");
            
            choice = Console.ReadLine();
            Console.WriteLine();

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
                    // Exibimos o resumo da sessão aqui, antes de sair.
                    Console.WriteLine("Session Summary:");
                    Console.WriteLine($" - Breathing Activities Completed: {_breathingCount}");
                    Console.WriteLine($" - Reflecting Activities Completed: {_reflectingCount}");
                    Console.WriteLine($" - Listing Activities Completed: {_listingCount}");
                    Console.WriteLine("\nThank you for your time. Goodbye!");
                    Thread.Sleep(4000); // Pausa para o usuário ler o resumo.
                    break;
                default:
                    Console.WriteLine("Invalid choice. Please select a valid option.");
                    Thread.Sleep(2000);
                    break;
            }

            if (currentActivity != null)
            {
                currentActivity.Run();

                // Após a atividade rodar, incrementamos o contador correspondente.
                if (currentActivity is BreathingActivity)
                {
                    _breathingCount++;
                }
                else if (currentActivity is ReflectingActivity)
                {
                    _reflectingCount++;
                }
                else if (currentActivity is ListingActivity)
                {
                    _listingCount++;
                }
            }
        }
    }
}