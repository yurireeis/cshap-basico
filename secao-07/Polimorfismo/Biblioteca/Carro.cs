using System;

namespace Polimorfismo.Biblioteca
{
    public class Carro : Veiculo
    {
        public override void Mover() => Console.WriteLine("carro se movendo.");
    }
}
