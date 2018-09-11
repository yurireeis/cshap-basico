using System;
using Construtor.Biblioteca;

namespace Construtor
{
    class Program
    {
        static void Main(string[] args)
        {
            // construtor é a forma padrão de se construir um objeto
            // no primeiro exemplo vemos um construtor sem parâmetros, já no segundo foram passados parâmetros (sobrecarga)
            Carro carro = new Carro();
            Carro carro2 = new Carro("Hyundai", "HB20");
        }
    }
}
