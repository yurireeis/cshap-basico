using System;

namespace Condicional
{
    class Program
    {
        static void Main(string[] args)
        {
            uint ValorDepositado;
            Console.Write("Digite o valor a ser depositado: ");
            ValorDepositado = uint.Parse(Console.ReadLine());
            bool ValorVip = ValorDepositado > 100000;

            // estrutura condicional: if
            if (ValorVip) { Console.WriteLine("Cliente é VIP"); }
            else { Console.WriteLine("Cliente não é VIP"); }

            // estrutura condicional: switch
            // todo fluxo deve terminar com a palavra break
            Console.Write("Digite o seu estado civil: ");
            string EstadoCivil = Console.ReadLine();
            switch (EstadoCivil)
            {
                case "casado":
                    Console.WriteLine("morreu.");
                    break;
                case "solteiro":
                    Console.WriteLine("sucesso.");
                    break;
                default:
                    // qualquer valor não esperado
                    break;
            }
        }
    }
}
