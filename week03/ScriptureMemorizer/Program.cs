using System;

public class Program
{
    public static void Main(string[] args)
    {
        // 1. PREPARAÇÃO: Criar os objetos essenciais para o jogo.

        // Exemplo de uma referência de verso único
        Reference reference = new Reference("John", 3, 16); 
        
        // Exemplo de uma referência de intervalo (se você quiser testar)
        // Reference reference = new Reference("Proverbs", 3, 5, 6); 

        string scriptureText = "For God so loved the world, that he gave his only begotten Son, that whosoever believeth in him should not perish, but have everlasting life.";
        
        // Cria a instância principal da Escritura, passando a referência e o texto
        Scripture scripture = new Scripture(reference, scriptureText);

        // 2. LOOP PRINCIPAL DO PROGRAMA (O Jogo)
        string userInput = "";

        // O loop continua ENQUANTO o usuário não digitar 'quit' E a escritura não estiver completamente escondida
        while (userInput.ToLower() != "quit" && !scripture.IsCompletelyHidden())
        {
            // 3. EXIBIR E INTERAGIR

            // Limpa o console antes de cada exibição (requisito)
            Console.Clear();

            // Exibe a escritura atualizada (com palavras escondidas ou visíveis)
            Console.WriteLine(scripture.GetDisplayText());

            // Solicita a entrada do usuário
            Console.WriteLine("\nPress Enter to continue or type 'quit' to end:");
            userInput = Console.ReadLine();

            // 4. PROCESSAR A ENTRADA
            if (userInput.ToLower() != "quit")
            {
                // Esconde 3 palavras aleatórias a cada Enter
                scripture.HideRandomWords(3);
            }
        }

        // 5. ENCERRAMENTO

        // Limpa e mostra a tela final (caso o loop tenha terminado porque tudo foi escondido)
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