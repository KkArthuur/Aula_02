using System;
//IMPORTANTE!!! Pedi pra voce se poderia fazer os exercicios usando o write e read line e você deixou

public static class Exercicio5
{
    
    public static void Executar()
    {
        string nome = " ";
        string estiloMsc = " ";
        string artistaFav = " ";
        
       Console.Clear(); 
        Console.Write("Digite seu nome: ");
        nome = Console.ReadLine()!;

        Console.Write("Digite um estilo musical que voce goste: ");
        estiloMsc = Console.ReadLine()!;

        Console.Write("Digite seu artista favorito deste: ");
        artistaFav = Console.ReadLine()!;

        Console.WriteLine();
        Console.WriteLine();
        Console.WriteLine($"Eu sou {nome}, curto o estilo musical {estiloMsc} e meu artista favorito desse estilo é {artistaFav}.");
    }
}