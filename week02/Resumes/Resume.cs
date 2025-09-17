using System;
using System.Collections.Generic;

public class Resume // Aqui eu estou criando uma classe chamada Resume. Em resumo, uma classe é um molde para criar objetos.
{
    // Atributo para o nome da pessoa
    public string _name; // Aqui eu estou criando um atributo chamado _name. Atributos são as características que os objetos dessa classe terão. Eu preciso usar a palavra public para que esse atributo possa ser acessado fora da classe. Uso a palavra string para indicar que o atributo é uma cadeia de caracteres (texto). Eu uso o símbolo _ antes do nome do atributo para indicar que ele é um campo da classe. O _name é o nome da pessoa.

    public List<Job> _jobs = new List<Job>(); // Aqui eu estou criando um atributo chamado _jobs. Esse atributo é uma lista que pode conter vários objetos do tipo Job. Eu uso a palavra List<Job> para indicar que esse atributo é uma lista de objetos da classe Job. Eu inicializo essa lista com new List<Job>() para que ela comece vazia e possa receber objetos do tipo Job.

    // Método de comportamento
    public void Display() // Aqui eu estou criando um método chamado Display. Um método é uma ação que os objetos dessa classe podem realizar. Eu uso a palavra public para que esse método possa ser acessado fora da classe. Eu uso a palavra void para indicar que esse método não retorna nenhum valor. O nome do método é Display e ele não recebe nenhum parâmetro (informação de entrada). O corpo do método é o que ele faz quando é chamado. Nesse caso, ele imprime na tela o nome da pessoa e os detalhes de cada trabalho na lista de trabalhos.
    {
        Console.WriteLine($"Name: {_name}"); // Aqui eu estou falando para pegar o atributo _name, aquele que vc estabeleceu e imprimir na tela uma mensagem formatada.
        Console.WriteLine("Jobs:"); // Aqui eu estou imprimindo na tela a palavra "Jobs:" para indicar que a seguir virão os detalhes dos trabalhos.

        // Percorre cada objeto 'job' na lista '_jobs'
        foreach (Job job in _jobs) foreach (Job job in _jobs) // Aqui eu estou usando um loop foreach para percorrer cada objeto da lista _jobs. Para cada objeto da lista, eu vou chamar o método 
        // Display() desse objeto para imprimir os detalhes do trabalho.
        {
            // Chama o método Display() de CADA objeto 'job' na lista
            job.Display(); // Aqui eu estou chamando o método Display() do objeto job atual. Isso vai imprimir na tela os detalhes do trabalho, como o título, a empresa e os anos de início e término.
        }
    }
}