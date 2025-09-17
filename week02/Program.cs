using System;
using System.Collections.Generic; // Necessário para usar List

class Program
{
    static void Main(string[] args)
    {
        // Criando o primeiro objeto 'job' a partir da classe Job
        Job job1 = new Job(); // Aqui eu estou criando um objeto chamado job1 a partir da classe Job. Isso significa que job1 é uma instância da classe Job e pode usar seus atributos e métodos.
        job1._jobTitle = "Software Engineer";
        job1._company = "DEll";
        job1._startYear = 2027;
        job1._endYear = 2030;

        // Criando o segundo objeto 'job'
        Job job2 = new Job();
        job2._jobTitle = "Trainee Software Engineer";
        job2._company = "starlink";
        job2._startYear = 2026;
        job2._endYear = 2027;

        // Criando o objeto 'myResume' a partir da classe Resume
        Resume myResume = new Resume();
        myResume._name = "Rodrigo De Lima";

        // Adicionando os objetos 'job' à lista de empregos dentro do objeto 'myResume'
        myResume._jobs.Add(job1);
        myResume._jobs.Add(job2);

        // Chamando o método Display do objeto 'myResume'.
        // Ele vai exibir o nome e, em seguida, chamar o método Display de CADA emprego.
        myResume.Display();
    }
}