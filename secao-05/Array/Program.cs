using System;

namespace Array
{
    class Program
    {
        static void Main(string[] args)
        {
            // formas de criar um array
            string[] MarcasFamosas = { "Ferrari", "Google", "Coca-Cola" };
            string[] Nomes = new string[6]; // deste modo é necessário sinalizar o tamanho do array

            // array multidimensional
            // cada vírgula representa uma dimensão a mais
            // na instância, já é definido a quantidade de índices para cada dimensão
            // no caso abaixo, a primeira dimensão (0) é relativa a marcas de veículo
            // no caso abaixo, a primeira dimensão (1) é relativa a marcas de televisão
            string[,] Marcas = new string[1,4];
            Marcas[0,0] = "Fiat";
            Marcas[0,1] = "Chevrolet";
            Marcas[0,2] = "Renault";
            Marcas[0,3] = "Peugeot";

            Marcas[1,0] = "Philco";
            Marcas[1,1] = "CCE";
            Marcas[1,2] = "Toshiba";
            Marcas[1,3] = "Samsung";

            // outra forma de instanciar é a forma abaixo (com as mesmas regras acima)
            string[,] Marcas2 = new string[2,2] { { "FIAT", "Cevrolet" }, { "Philco","CCE" } };
        }
    }
}
