using System;
//IMPORTANTE!!! Pedi pra voce se poderia fazer os exercicios usando o write e read line e você deixou

public static class Exercicio4
{
    
    public static void Executar()
    {
        string nome = " ";
        int idade = 0;
        string hobby1 = " ";
        string hobby2 = " ";
        string cursoGraduacao = " ";
       Console.Clear(); 
        Console.Write("Digite seu nome: ");
        nome = Console.ReadLine()!;

        Console.Write("Digite sua idade: ");
        idade = int.Parse(Console.ReadLine()!);

        Console.Write("Digite seu passatempo favorito: ");
        hobby1 = Console.ReadLine()!;

        Console.Write("Digite digite seu segundo passatempo favorito: ");
        hobby2 = Console.ReadLine()!;

        Console.Write("Digite um curso que você pretende fazer sua graduação: ");
        cursoGraduacao = Console.ReadLine()!;

        Console.WriteLine();
        Console.WriteLine();
        Console.WriteLine($"Meu nome é {nome}, tenho {idade} anos, meus dois passatempos favoritos são {hobby1} e {hobby2}, e pretendo cursar a graduação em {cursoGraduacao}.");
    }
}