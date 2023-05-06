using System;

class Program
{
    static void Main(string[] args)
    {
        double salario;
        salario = 3000.15;

        int salarioInteiro;
        // Using casting
        salarioInteiro = (int)salario;
        // Using int.Parse
        salarioInteiro = int.Parse(salario.ToString());

        // And other types 
        long x = 2000000000000000000;
        short y = 15000;
        float altura = 1.82f;


    }
}