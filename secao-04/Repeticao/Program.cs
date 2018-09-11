using System;

namespace Repeticao
{
    class Program
    {
        static void Main(string[] args)
        {
            // while: enquanto a expressão for verdadeira executa o código
            string meuNome = "";
            string[] nomes = {"Yuri", "Luiz", "Silva", "Reis"};
            while (meuNome != "Yuri")
            {
                Console.Write("Digite o meu nome: ");
                meuNome = Console.ReadLine();
            }

            // for/foreach
            for (int i = 0; i < 9; i++) { Console.WriteLine(i); }

            foreach(string nome in nomes) { Console.WriteLine(nome); }
        }
    }
}
