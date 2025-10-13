using System;

// Esta é a classe principal que controla o fluxo do programa.
class Program
{
    // O método Main é o ponto de entrada de qualquer aplicação C#.
    static void Main(string[] args)
    {
        // A variável 'choice' armazena a seleção do usuário no menu.
        string choice = "";

        // O loop 'while' mantém o menu rodando até que o usuário escolha a opção "4" (Sair).
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

            // A variável 'currentActivity' é declarada como o tipo base 'Activity'.
            // Isso permite que ela armazene qualquer objeto de uma classe que herde de Activity.
            // Este é o princípio do polimorfismo em ação.
            Activity currentActivity = null;

            // O 'switch' direciona o programa com base na escolha do usuário.
            switch (choice)
            {
                case "1":
                    // Cria uma nova instância de BreathingActivity.
                    currentActivity = new BreathingActivity();
                    break;
                case "2":
                    // Cria uma nova instância de ReflectingActivity.
                    currentActivity = new ReflectingActivity();
                    break;
                case "3":
                    // Cria uma nova instância de ListingActivity.
                    currentActivity = new ListingActivity();
                    break;
                case "4":
                    // Exibe a mensagem de despedida. O loop 'while' irá terminar.
                    Console.WriteLine("Goodbye!");
                    break;
                default:
                    // Lida com qualquer entrada inválida.
                    Console.WriteLine("Invalid choice. Please select a valid option.");
                    Thread.Sleep(2000); // Pausa para o usuário ler a mensagem.
                    break;
            }

            // Se uma atividade válida foi escolhida (currentActivity não é nula),
            // o método Run() da atividade específica será chamado.
            if (currentActivity != null)
            {
                currentActivity.Run();
            }
        }
    }
}