// É necessário incluir estes 'usings' para ter acesso a funcionalidades
// como Console, Thread, List e DateTime.
using System;
using System.Collections.Generic;
using System.Threading;

// Esta é a classe base para todas as outras atividades.
// Ela contém os atributos e métodos que são comuns a todas.
public class Activity
{
    // Atributos (campos) protegidos.
    // 'protected' permite que esta classe e as classes filhas (como BreathingActivity)
    // acessem estas variáveis, mas elas ficam escondidas do resto do programa.
    protected string _name;
    protected string _description;
    protected int _duration;

    // Construtor da classe.
    // É chamado quando um novo objeto Activity (ou de uma classe filha) é criado.
    // Inicializa os campos com valores padrão para evitar erros.
    public Activity()
    {
        _name = "";
        _description = "";
        _duration = 0;
    }

    // Este é o método que será substituído (overridden) pelas classes filhas.
    // A palavra-chave 'virtual' é essencial aqui. Ela permite que cada atividade
    // (Breathing, Reflecting, etc.) tenha sua própria implementação do método Run().
    public virtual void Run()
    {
        // Este método na classe base pode ficar vazio.
        // Ele existe para que o polimorfismo funcione corretamente no Program.cs.
    }

    // Método para exibir a mensagem inicial e configurar a duração.
    public void DisplayStartingMessage()
    {
        Console.Clear();
        Console.WriteLine($"Welcome to the {_name} Activity!\n");
        Console.WriteLine(_description + "\n");
        Console.Write("How long, in seconds, would you like for your session? ");
        
        // Excelente uso do TryParse para validar a entrada do usuário de forma segura.
        if (int.TryParse(Console.ReadLine(), out int duration))
        {
            _duration = duration;
        }
        else
        {
            Console.WriteLine("Invalid input. Defaulting to 30 seconds.");
            _duration = 30; // Define um valor padrão se a entrada for inválida.
        }

        Console.Clear(); // Limpa a tela antes de começar
        Console.WriteLine("Get ready...");
        ShowSpinner(5); // Uma pausa para o usuário se preparar.
    }

    // Método para exibir a mensagem de finalização.
    public void DisplayEndingMessage()
    {
        Console.WriteLine("\nWell done!!");
        ShowSpinner(3);
        Console.WriteLine($"\nYou have completed another {_duration} seconds of the {_name} Activity.");
        ShowSpinner(5);
    }

    // Método utilitário para mostrar uma animação de spinner.
    // Ajuda a criar pausas visuais para o usuário.
    public void ShowSpinner(int seconds)
    {
        List<string> animationStrings = new List<string> { "|", "/", "-", "\\" };
        DateTime endTime = DateTime.Now.AddSeconds(seconds);

        int i = 0;
        while (DateTime.Now < endTime)
        {
            Console.Write(animationStrings[i]);
            Thread.Sleep(250);
            Console.Write("\b \b"); // Apaga o caractere anterior

            i++;
            if (i >= animationStrings.Count)
            {
                i = 0;
            }
        }
        Console.WriteLine(); // Pula para a próxima linha ao final da animação
    }

    // Método utilitário para mostrar uma contagem regressiva.
    public void ShowCountDown(int seconds)
    {
        for (int i = seconds; i > 0; i--)
        {
            Console.Write(i);
            Thread.Sleep(1000);
            Console.Write("\b \b"); // Apaga o número
        }
        Console.WriteLine(); // Pula para a próxima linha
    }
}