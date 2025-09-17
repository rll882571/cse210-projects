using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        // === Parte 1: Coletar os números do usuário ===

        List<int> numbers = new List<int>();
        int userNumber = -1; // Inicia com um valor que não seja 0

        Console.WriteLine("Enter a list of numbers, type 0 when finished.");

        while (userNumber != 0)
        {
            Console.Write("Enter number: ");
            string userInput = Console.ReadLine();
            userNumber = int.Parse(userInput);

            // Adiciona o número à lista apenas se ele NÃO for 0.
            if (userNumber != 0)
            {
                numbers.Add(userNumber);
            }
        }

        // Verifica se a lista não está vazia para evitar erros
        if (numbers.Count > 0)
        {
            // === Parte 2: Calcular a soma ===
            int sum = 0;
            foreach (int number in numbers)
            {
                sum += number; // O mesmo que sum = sum + number;
            }

            Console.WriteLine($"The sum is: {sum}");


            // === Parte 3: Calcular a média ===
            // É importante converter 'sum' para float para obter um resultado com decimais.
            float average = ((float)sum) / numbers.Count;
            Console.WriteLine($"The average is: {average}");


            // === Parte 4: Encontrar o maior número ===
            int maxNumber = numbers[0]; // Começa assumindo que o primeiro número é o maior

            foreach (int number in numbers)
            {
                // Se o número atual for maior que o maior número encontrado até agora...
                if (number > maxNumber)
                {
                    // ...então atualizamos o maior número.
                    maxNumber = number;
                }
            }
            
            Console.WriteLine($"The largest number is: {maxNumber}");
        }
        else
        {
            Console.WriteLine("No numbers were entered.");
        }
    }
}