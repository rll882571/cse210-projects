using System;
using System.Collections.Generic;

public class Program
{
    public static void Main(string[] args)
    {

        List<Video> videoList = new List<Video>();

        Video video1 = new Video("Leraning C# is hard", "Dev now", 1800);

        video1.AddComment(new Comment("Ana Silva", "Excelente!"));
        video1.AddComment(new Comment("Taylor smish", "helped a lot."));
        video1.AddComment(new Comment("Carlos Dias", "Mui bien!"));

        videoList.Add(video1);


        Video video2 = new Video("Chocolat cake", "Key chef", 950);

        video2.AddComment(new Comment("Fernanda Lima", "Fiz a receita e ficou divino!"));
        video2.AddComment(new Comment("Gustavo Reis", "Qual a temperatura do forno?"));
        video2.AddComment(new Comment("Helena Souza", "O meu ficou um pouco seco, o que pode ser?"));
        video2.AddComment(new Comment("Joao Pedro", "Melhor bolo que já fiz."));

        videoList.Add(video2);


        Video video3 = new Video("Guia de Viagem para o Japão", "Mundo Afora", 2500);

        video3.AddComment(new Comment("Larissa Mendes", "Sonho em conhecer Kyoto!"));
        video3.AddComment(new Comment("Marcos Andrade", "Dicas valiosas sobre transporte, obrigado."));
        video3.AddComment(new Comment("Patricia Barros", "Faltou falar dos preços, mas o vídeo é lindo."));

        videoList.Add(video3);



        Console.WriteLine("--- List ---");
        Console.WriteLine();

        foreach (Video video in videoList)
        {
            Console.WriteLine($"Tittle: {video._title}");
            Console.WriteLine($"Author: {video._author}");
            Console.WriteLine($"length (segundos): {video._lengthInSeconds}");
            Console.WriteLine($"Number of comments: {video.GetNumberOfComments()}"); 
            Console.WriteLine("comments:");
            
            foreach (Comment comment in video.GetComments())
            {
                Console.WriteLine($"  - {comment._commenterName}: \"{comment._text}\"");
            }

            Console.WriteLine("-----------------------------------");
            Console.WriteLine();
        }
    }
}