using System;

class Program
{
    static void Main(string[] args)
    {
        // para essa atividade a primeira coisa que voce precisa fazer é criar um numero aleatírio.
        // 1- Crie um objeto da classe Random
        // 2- Depois do Random crie uma variável chamada RandomGenerator
        // 3 use o símbolo de igual que significa recebe, ou seja a variável que você criou vai receber o valor do Random
        // 4 Depois voce vai usar o new Random(). o new é usado quando quer criar um novo objeto. Esse objeto é um contador aleatorio.
        Random randomGenerator = new Random();
        int magicNumber = randomGenerator.Next(1, 101);
        // 5-  Aqui voce  esta informando ao programa, crie outra variável chamada 
        // magicalNumber, lembra que a variável precisa ser de um tipo? pois bem, essa variavel vai ser do tipo int
        // 6- Lembra do randomGenerator que você criou? Pois bem, essa variável vai receber o valor do randomGenerator. VocÊ pediu para gerar um numerou 
        // aleatorio mas vocÊ precisa passar um parametro, gere um numero aleatorio de x a y... Isso você faz usando 
        // o .Next(1, 101)
        int guess = -1;
        // 7- Crie uma variável chamada guess, que vai ser do 
        // tipo int e vai receber o valor -1. Mas porque é necessário criar essa variável antes?
        // No inicio do loop você precisa de uma variável para comparar com o magicNumber, o magicNumber é o que foi
        // gerado aleatoriamente,
        while (guess != magicNumber)
        {
            Console.WriteLine("What is your guess? ");
            guess = int.Parse(Console.ReadLine());
            if (magicNumber > guess)
            {
                Console.WriteLine("Higher");
                guess = int.Parse(Console.ReadLine());
            }
            else if (magicNumber < guess)
            {
                Console.WriteLine("Lower");
                guess = int.Parse(Console.ReadLine());
            }
            else
            {
                Console.WriteLine("You guessed it!");
            }


        }

    }
}