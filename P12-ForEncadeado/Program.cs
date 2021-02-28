using System;

namespace P12_ForEncadeado
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Aula 12");
            double valorInvestido = 1000;
            double fatorRendimento = 1.0036;

            for (int contadorAno = 1; contadorAno <= 5; contadorAno++)
            {
                for(int contadorMes = 1; contadorMes<= 12; contadorMes++)
                {
                    valorInvestido *= fatorRendimento;
                    Console.WriteLine("No ano " + contadorAno + " e mês " + contadorMes + " Valor total é R$" + valorInvestido);
                }
                fatorRendimento += 0.0010;
                Console.WriteLine("No total vai ser R$" + valorInvestido);
            }


        }
    }
}

