using System;

namespace Biblioteca
{
    // sintaxe da herança abaixo
    public class Carro : Veiculo
    {
        public int Rodas = 4;


        public void Mover()
        {
            Console.WriteLine("movendo com o carro");
            base.Mover();
        }
    }
}
