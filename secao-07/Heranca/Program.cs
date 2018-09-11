using System;
using Biblioteca;

namespace Heranca
{
    class Program
    {
        static void Main(string[] args)
        {
            Carro carro = new Carro();
            Moto moto = new Moto();
            Veiculo veiculo = new Veiculo();

            Console.WriteLine("Quantidade de rodas na moto: " + moto.Rodas);
            Console.WriteLine("Quantidade de rodas no carro: " + carro.Rodas);

            // sobrescrita: fazer com que a classe filho implemente um comportamento diferente da classe pai
            // os métodos abaixo, tanto Move do carro quanto da moto sobrescrevem o comportamento da original
            moto.Mover();
            carro.Mover();
        }
    }
}
