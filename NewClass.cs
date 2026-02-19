// -- Arquivo Exercicio1.cs
public static class Exercicio1
{
    public static void Executar()
    {
		    Console.WriteLine();
		    
        Console.WriteLine("Hello World");
        Console.WriteLine();
    }
}

// -- Arquivo Exercicio2.cs
public static class Exercicio2
{
    
    
    public static void Executar()
    {
        string nome = "Arthur Campos";
        Console.WriteLine($"{nome}");
        Console.WriteLine();
    }
}

// -- Arquivo Exercicio3.cs
public static class Exercicio3
{
    public static void Executar()
    {
        int resultado = 0;
        int soma1 = 0;
        int soma2 = 0;

        Console.Write("Digite o valor de soma1: ");
        soma1 = int.Parse(Console.ReadLine()!);

        Console.Write("Digite o valor de soma2: ");
        soma2 = int.Parse(Console.ReadLine()!);

        resultado = soma1 + soma2;

        Console.WriteLine($"Resultado da soma: {resultado}");
        Console.WriteLine();
    }
}
public static class Exercicio4
{
    public static void Executar()
    {
        string nome = "";
        int idade = 0;
        string hobby1 = "";
        string hobby2 = "";
        string cursoGraduacao = "";
        
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