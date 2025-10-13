using System;
using System.Collections.Generic;
using System.Threading;

// A classe ListingActivity herda da classe base Activity.
public class ListingActivity : Activity
{
    // Campos privados específicos desta atividade.
    private int _count;
    private List<string> _prompts;
    private Random _random;

    // Construtor da ListingActivity.
    public ListingActivity()
    {
        // Define os valores para os campos herdados da classe base.
        _name = "Listing Activity";
        _description = "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.";
        
        _count = 0;
        _random = new Random();

        // Popula a lista de prompts (sugestões).
        _prompts = new List<string>
        {
            "Who are people that you appreciate?",
            "What are personal strengths of yours?",
            "Who are people that you have helped this week?",
            "When have you felt the Holy Ghost this month?",
            "Who are some of your personal heroes?"
        };
    }

    // Método que substitui o Run() da classe base com a lógica desta atividade.
    // A palavra-chave 'override' é fundamental aqui.
    public override void Run()
    {
        // 1. Mostra a mensagem de boas-vindas e define a duração.
        DisplayStartingMessage();

        // 2. Exibe o prompt inicial.
        Console.WriteLine("\nList as many responses as you can to the following prompt:");
        Console.WriteLine($"--- {GetRandomPrompt()} ---");
        
        // 3. Dá uma contagem regressiva para o usuário começar a pensar.
        Console.Write("You may begin in: ");
        ShowCountDown(5);

        // 4. Chama o método que captura a lista do usuário.
        GetListFromUser();

        // 5. Exibe o número de itens que o usuário listou.
        Console.WriteLine($"\nYou listed {_count} items.");

        // 6. Mostra a mensagem de encerramento.
        DisplayEndingMessage();
    }

    // Método privado para capturar a entrada do usuário.
    private void GetListFromUser()
    {
        // Reinicia a contagem e cria uma lista para guardar as respostas.
        _count = 0;
        List<string> userResponses = new List<string>();

        // Define o tempo de término para o loop.
        DateTime endTime = DateTime.Now.AddSeconds(_duration);

        Console.WriteLine(); // Adiciona uma linha em branco para formatação.

        while (DateTime.Now < endTime)
        {
            Console.Write("> ");
            string item = Console.ReadLine(); // O programa vai pausar aqui até o usuário pressionar Enter.

            // A verificação do tempo (no `while`) só acontece DEPOIS que o usuário envia uma resposta.
            // Isso significa que o tempo total pode exceder a duração definida.

            // Adiciona o item à lista e incrementa o contador se não estiver vazio.
            if (!string.IsNullOrWhiteSpace(item))
            {
                userResponses.Add(item);
                _count++;
            }
        }
    }

    // Método privado para pegar um prompt aleatório da lista.
    private string GetRandomPrompt()
    {
        int index = _random.Next(_prompts.Count);
        return _prompts[index];
    }
}