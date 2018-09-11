using System;

namespace Biblioteca
{
    public class Veiculo
    {
      public string Marca;
      public string Modelo;
      public int QuantidadeMaxPassageiro;
      public int Ano;

      // usando a palavra chave virtual para informar que esse método é sobrescrito em classes filhas
      public virtual void Mover() => Console.WriteLine("movendo com o veículo (base)");
    }
}
