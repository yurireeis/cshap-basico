using System;
using System.Collections.Generic;

namespace Lista
{
    class Program
    {
        static void Main(string[] args)
        {
            // lista é um array sem tamanho definido
            List<string> Marcas = new List<string>();

            // adicionando um elemento a variavel marcas
            Marcas.Add("FIAT");
            Marcas.Add("Chevrolet");
            Marcas.Add("Renault");
            Marcas.Add("Peugeot");
            Marcas.Add("Volkswagen");

            foreach (string marca in Marcas) { Console.WriteLine(marca); }
        }
    }
}
