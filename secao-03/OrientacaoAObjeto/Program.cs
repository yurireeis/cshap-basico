using System;
using Veiculo;

namespace OrientacaoAObjeto
{
    class Program
    {
        static void Main(string[] args)
        {
            // construção do objeto se dá a partir de características que ele possui
            // métodos = ações
            // classe é como uma fábrica
            Carro carro = new Carro();
            carro.AbrirPorta();
            string intensidade = carro.AcenderFarolAutomaticamente();
            Console.WriteLine("A intensidade do farol é: " + intensidade);
            // instanciando um valor estático
            Console.WriteLine("Valor estático da classe: " + Carro.quantidadeDeCarrosProduzidos);
        }
    }
}
