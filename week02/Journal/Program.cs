using System;

public class Program
{
    public static void Main(string[] args)
    {
        Jornal meuJornal = new Jornal();
        PromptGenerator promptGenerator = new PromptGenerator();
        string escolha = "";

        while (escolha != "5")
        {
            Console.WriteLine("Escolha uma opção:");
            Console.WriteLine("1. Escrever nova entrada");
            Console.WriteLine("2. Exibir diário");
            Console.WriteLine("3. Salvar no arquivo");
            Console.WriteLine("4. Carregar do arquivo");
            Console.WriteLine("5. Sair");
            Console.Write("Sua escolha: ");
            escolha = Console.ReadLine();

            if (escolha == "1")
            {
                string prompt = promptGenerator.GetRandomPrompt();
                Console.WriteLine(prompt);
                Console.Write("> ");
                string resposta = Console.ReadLine();

                Entry novaEntrada = new Entry();
                novaEntrada._promptText = prompt;
                novaEntrada._entryText = resposta;
                novaEntrada._date = DateTime.Now.ToShortDateString();
                
                meuJornal.AddEntry(novaEntrada);
            }
            else if (escolha == "2")
            {
                meuJornal.Display();
            }
            else if (escolha == "3")
            {
                Console.Write("Digite o nome do arquivo para salvar: ");
                string nomeArquivo = Console.ReadLine();
                meuJornal.SaveToFile(nomeArquivo);
            }
            else if (escolha == "4")
            {
                Console.Write("Digite o nome do arquivo para carregar: ");
                string nomeArquivo = Console.ReadLine();
                meuJornal.LoadFromFile(nomeArquivo);
            }
            else if (escolha == "5")
            {
                Console.WriteLine("Saindo do programa. Tchau!");
            }
            else
            {
                Console.WriteLine("Opção inválida. Por favor, escolha um número de 1 a 5.");
            }
        }
    }
}