using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Executing the project 5 - Characters and Texts");

        char letra = 'a';
        Console.WriteLine(letra);

        letra = (char)65;
        Console.WriteLine(letra);


        letra = (char)(85 + 1);
        Console.WriteLine(letra);

        string firstPhrase = "Alura - Cursos de Tecnologia";

        Console.WriteLine(firstPhrase);

        string cursosDisponiveis = @"Cursos disponíves:
-Go
-C#
-Java";

        Console.WriteLine(cursosDisponiveis);
    }
}