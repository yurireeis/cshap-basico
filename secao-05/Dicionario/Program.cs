using System;
using System.Collections.Generic;

namespace Dicionario
{
    class Program
    {
        static void Main(string[] args)
        {
            // criando dicionarios (chave-valor) ou índices personalizados
            Dictionary<string, int> dicionario = new Dictionary<string, int>();
            dicionario.Add("T1", 128);
            dicionario.Add("T2", 256);
            Console.WriteLine("valor da chave T1" + dicionario["T1"]);
        }
    }
}
