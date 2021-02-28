using System;

namespace _2_CriandoVariaveis
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Criando Váriaveis.");
            int idade = 33;
            Console.WriteLine(idade);
            idade = 10;
            Console.WriteLine(idade);
            int result;
            result = 2021 - idade;
            Console.WriteLine("Ele nasceu em " + result+ ", ele está jovem.");
            Console.ReadLine();
        }
    }
}
