using System;

public class Job // Aqui eu estou criando uma classe chamada job. Em resumo, uam classe é um molde para criar objetos.
{
    
    public string _jobTitle; // Aqui eu estou criando os atributos da classe job. Atributos são as características que os objetos dessa classe terão.Eu preciso usar a papavra public para que esses atributos possam ser acessados fora da classe. uso a palavra 
    // string para indicar que o atributo é uma cadeia de caracteres (texto) e int para indicar que o atributo é um número inteiro. Eu uso o simbolo _ antes do nome do atributo para indicar que ele é um campo da classe.O jobTitle é o título do trabalho, 
    
    public string _company; // company é o nome da empresa,
    public int _startYear; // startYear é o ano de início do trabalho e endYear é o ano de término do trabalho.
    public int _endYear;

    // Método de comportamento
    public void Display() // Aqui eu estou criando um método chamado Display. Um método é uma ação que os objetos dessa classe
    //  podem realizar. Eu uso a palavra public para que esse método possa ser acessado fora da classe. Eu uso a palavra void para indicar que esse método não retorna
    //  nenhum valor. O nome do método é Display e ele não recebe nenhum parâmetro (informação de entrada). O corpo do método é o que ele faz quando é chamado. Nesse caso, 
    // ele imprime na tela uma mensagem formatada com os atributos do trabalho.
    {
        Console.WriteLine($"{_jobTitle} ({_company}) {_startYear}-{_endYear}"); // Aqui eu estou falando para pegar os atributos do trabalho, aqueles que vc estabeleceu e imprimir na tela uma mensagem formatada.
    }
}