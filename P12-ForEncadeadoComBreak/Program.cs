using System;

namespace P12_ForEncadeadoComBreak
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int contadorLinha = 0; contadorLinha < 10; contadorLinha++)
            {
               
                for (int contadorColuna = 0; contadorColuna <= contadorLinha; contadorColuna++)
                {
                    Console.Write("*");
                  
                }
                Console.WriteLine("*");
            }
        }
    }
}
