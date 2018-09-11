using System;

namespace TrabalhandoComTextos
{
    class Program
    {
        static void Main(string[] args)
        {
            const string texto = "Olá amigos. Estou muito feliz de estar aqui com vocês!";
            const string palavra = "feliz";
            const string nome = "Yuri";

            // é possível de se utilizar algumas propriedades da string
            Console.WriteLine("Tamanho do texto: " + texto.Length);
            Console.WriteLine("Encontrando o primeiro índice de uma palavra dentro de outra string: " + texto.IndexOf(palavra));
            Console.WriteLine("Encontrando o último índice de uma palavra dentro de outra string: " + texto.LastIndexOf(palavra));

            // substituindo um determinado texto com métodos da classe string
            const string outraPalavra = "triste";
            Console.WriteLine(texto.Replace(palavra, outraPalavra));

            // formatando string
            string texto2 = String.Format("Bem vindo {0}! Feliz natal!", nome);
            Console.WriteLine(texto2);

            // ou pode ser feito da seguinte forma
            string texto3 = String.Format("Olá {0}!", "mundo");
            Console.WriteLine(texto3);
        }
    }
}
