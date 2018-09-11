using System;
using Polimorfismo.Biblioteca;

namespace Polimorfismo
{
    class Program
    {
        static void Main(string[] args)
        {
            Carro carro = new Carro();
            Program.MoverVeiculo(carro);
        }

        // a classe veículo é base da moto, carro e ônibus. Por isso, ao passar um objeto das classes filhas
        // irá funcionar normalmente
        public static void MoverVeiculo(Veiculo veiculo) => veiculo.Mover();
    }
}
