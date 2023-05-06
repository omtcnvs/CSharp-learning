using System;

class Program
{
    static void Main(string[] args)
    {
        int idade = 17;
        Boolean acompanhado = false;

        if (idade < 18 && !acompanhado)
        {
            Console.WriteLine("Não pode entrar");
        }

    }
}