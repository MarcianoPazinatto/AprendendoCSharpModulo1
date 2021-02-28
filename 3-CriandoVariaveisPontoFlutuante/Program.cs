using System;

namespace _3_CriandoVariaveisPontoFlutuante
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Criando variaveis com ponto flutuante");
            double salario = 1200.70;
            int valor = 200;
            double result;
            result = salario - valor;
            Console.WriteLine("Meu salario é " + salario);
            Console.WriteLine("subtraindo double com int é " + result);
        }
    }
}
