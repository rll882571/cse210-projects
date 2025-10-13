using System;
using System.Collections.Generic;
using System.Threading;

// A classe ReflectingActivity herda da classe base Activity.
public class ReflectingActivity : Activity
{
    // Campos privados específicos desta atividade.
    private List<string> _prompts;
    private List<string> _questions;
    private Random _random; 

    // Construtor da ReflectingActivity.
    public ReflectingActivity()
    {
        // Define os valores para os campos herdados da classe base.
        _name = "Reflecting Activity";
        _description = "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.";
        
        // Inicializa o gerador de números aleatórios.
        _random = new Random();

        // Popula a lista de prompts (sugestões iniciais).
        _prompts = new List<string>
        {
            "Think of a time when you stood up for someone else.", 
            "Think of a time when you did something really difficult.", 
            "Think of a time when you helped someone in need.", 
            "Think of a time when you did something truly selfless." 
        };
        
        // Popula a lista de perguntas para reflexão.
        _questions = new List<string>
        {
            "Why was this experience meaningful to you?", 
            "Have you ever done anything like this before?", 
            "How did you get started?", 
            "How did you feel when it was complete?", 
            "What made this time different than other times when you were not as successful?",
            "What is your favorite thing about this experience?",
            "What could you learn from this experience that applies to other situations?",
            "What did you learn about yourself through this experience?", 
            "How can you keep this experience in mind in the future?" 
        };
    }

    // Método que substitui o Run() da classe base com a lógica desta atividade.
    // A palavra-chave 'override' é fundamental aqui.
    public override void Run()
    {
        // 1. Mostra a mensagem de boas-vindas e define a duração.
        DisplayStartingMessage();

        // 2. Exibe um prompt aleatório e espera o usuário se preparar.
        Console.WriteLine("\nConsider the following prompt:");
        Console.WriteLine($"\n--- {GetRandomPrompt()} ---");
        Console.WriteLine("\nWhen you have something in mind, press enter to continue.");
        Console.ReadLine(); // Pausa até o usuário pressionar Enter.
        
        Console.WriteLine("Now ponder on each of the following questions as they relate to this experience.");
        Console.Write("You may begin in: ");
        ShowCountDown(5); // Contagem regressiva para iniciar a reflexão.
        Console.Clear();

        // 3. Loop que exibe perguntas aleatórias até o tempo acabar.
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(_duration);
        
        while (DateTime.Now < endTime)
        {
            Console.Write($"> {GetRandomQuestion()} ");
            ShowSpinner(10); // Pausa de 10 segundos para o usuário refletir.
            Console.WriteLine();
        }

        // 4. Mostra a mensagem de finalização.
        DisplayEndingMessage();
    }

    // Método privado para pegar um prompt aleatório da lista.
    private string GetRandomPrompt()
    {
        int index = _random.Next(_prompts.Count);
        return _prompts[index];
    }

    // Método privado para pegar uma pergunta aleatória da lista.
    private string GetRandomQuestion()
    {
        int index = _random.Next(_questions.Count);
        return _questions[index];
    }
}