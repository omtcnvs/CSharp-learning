using System;

class Program
{
    static void Main(string[] args)
    {
        int mes = 0;
        int mes1 = 0;
        int mes2 = 0;
        double investimento = 1000.0;
        double investimento1 = 1000.0;
        double investimento2 = 1000.0;

        Console.WriteLine("Laço While");
        while (mes < 12)
        {
            investimento += investimento * 0.005;
            mes++;
            Console.WriteLine("Seu saldo do mês " + mes + " da sua conta poupança é de: R$" + Math.Round(investimento, 2).ToString());
        }

        Console.WriteLine("Laço DoWhile");
        do
        {
            investimento1 += investimento1 * 0.005;
            mes1++;
            Console.WriteLine("Seu saldo do mês " + mes1 + " da sua conta poupança é de: R$" + Math.Round(investimento1, 2).ToString());
        } while (mes1 < 12);

        Console.WriteLine("Laço For");
        for (int i = 0; i < 12; i++)
        {
            investimento2 += investimento2 * 0.005;
            mes2++;
            Console.WriteLine("Seu saldo do mês " + mes2 + " da sua conta poupança é de: R$" + Math.Round(investimento2, 2).ToString());
        }
        // break; is a reserved word to break for execution
    }
}