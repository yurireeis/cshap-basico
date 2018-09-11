using System;

namespace Biblioteca
{
    // sintaxe da herança abaixo
    public class Moto : Veiculo
    {
        public int Rodas = 2;

        // sobrescrita
        // usando a palavra chave override para deixar claro que esse método sobrescreve o método da classe pai
        public override void Mover()
        {
            Console.WriteLine("movendo com a moto");
            // base referencia a propriedades/métodos da classe base
            base.Mover();
        }
    }
}
