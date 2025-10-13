using System;
using System.Threading;

// A classe BreathingActivity herda da classe base Activity.
// Isso significa que ela tem acesso a todos os métodos e campos 'protected'
// da classe Activity, como _name, _duration, DisplayStartingMessage(), etc.
public class BreathingActivity : Activity
{
    // Construtor da BreathingActivity.
    // Ele não precisa de parâmetros, pois os valores são fixos para esta atividade.
    public BreathingActivity()
    {
        // Define os valores para os campos herdados da classe base.
        _name = "Breathing Activity";
        _description = "This activity will help you relax by walking you through breathing in and out slowly. Clear your mind and focus on your breathing.";
    }

    // Este é o método principal que executa a lógica específica da atividade de respiração.
    // A palavra-chave 'override' é ESSENCIAL aqui.
    // Ela indica que este método está substituindo o método 'virtual' Run() da classe Activity.
    public override void Run()
    {
        // 1. Chama o método da classe base para mostrar a mensagem de boas-vindas
        // e perguntar a duração.
        DisplayStartingMessage();

        // 2. Define o tempo de término para controlar a duração total da atividade.
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(_duration);

        // 3. Loop principal da atividade: continua rodando até o tempo acabar.
        while (DateTime.Now < endTime)
        {
            // Mensagem e pausa para Inspirar
            Console.Write("\nBreathe in... ");
            ShowCountDown(4); // Pausa por 4 segundos

            // Garante que não entremos na próxima fase se o tempo já tiver acabado.
            if (DateTime.Now >= endTime) break;

            // Mensagem e pausa para Expirar
            Console.Write("Now breathe out... ");
            ShowCountDown(6); // Pausa por 6 segundos
        }

        // 4. Chama o método da classe base para exibir a mensagem de finalização.
        DisplayEndingMessage();
    }
}