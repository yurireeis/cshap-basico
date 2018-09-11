using System;

namespace Excecoes
{
    class Program
    {
        static void Main(string[] args)
        {
            // exception é uma classe específica pra erros
            Console.Write("Digite um número: ");

            try
            {
                int numero = int.Parse(Console.ReadLine());
            }
            catch (FormatException)
            {
                Console.WriteLine("Não foi localizado número na frase!");
            }
            finally 
            {
                Console.WriteLine("Programa finalizado.");
            }
        }
    }
}
