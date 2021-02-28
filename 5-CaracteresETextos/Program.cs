using System;

namespace _5_CaracteresETextos
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando projeto 5");
            char primeiraLetra = 'a';
            Console.WriteLine(primeiraLetra);
            primeiraLetra = (char)65;
            Console.WriteLine(primeiraLetra);
            primeiraLetra = (char)(65+1);
            Console.WriteLine(primeiraLetra);

            string fraseDoDia = "O hoje é um presente.";
            Console.WriteLine(fraseDoDia);
            string frase = "O hoje é um presente. " + 2021;
            Console.WriteLine(frase);
            string fraseSeparada =
@" -C# 
 -Java
 -Python";
            Console.WriteLine(fraseSeparada);
        }
    }
}
