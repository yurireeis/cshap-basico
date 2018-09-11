using System;

namespace TiposPrimitivos
{
    class Program
    {
        static void Main(string[] args)
        {
            // tipos primitivos
            // byte: inteiro sem sinal (positivo) - 0 a 255
            byte meuByte = 1;

            // pode ser declarado da seguinte forma também System.Byte meuByte2 = 255;
            // SByte: vai de -128 a 127
            sbyte meuSByte = -14;
            Console.WriteLine("valor do meu byte é: " + meuByte);
            Console.WriteLine("valor do meu sbyte é: " + meuSByte);

            // int, short e long vão de negativo ao positivo, com diferença para a capacidade
            int meuInteiro = -1422254;
            Console.WriteLine("valor do meu inteiro negativo: " + meuInteiro);

            // também temos o ushort, uint e ulong, que somente aceitam números positivos e consequentemente 
            // tem um range maior positivo
            uint meuInteiro2 = 1165156113;
            Console.WriteLine("valor do meu inteiro sem sinal: " + meuInteiro2);

            // também temos pontos flutuantes
            // a classe do float é a Single (System.Single)
            // permitem precisão
            // float = 32 bits, double = 64 bits, decimal = 128 bits
            // para float é necessario adicionar o sufixo f ao número (quando declarado)
            // para decimal é necessario adicionar o sufixo m ao número (quando declarado)
            float meuFloat = 2.22f;
            double meuDouble = 11515616.2151;
            decimal meuDecimal = 1231321321321321.21312m;

            Console.WriteLine("valor do meu ponto flutuante de 32 bits é: " + meuFloat);
            Console.WriteLine("valor do meu double é: " + meuDouble);
            Console.WriteLine("valor do meu decimal é: " + meuDecimal);

            // os tipos que armazenam texto(s) são: var e string
            // aspas duplas para uma cadeia de caracteres. para caracter único, usar aspas simples (like java)
            // para cada caracter, é adicionado 16 bits (pois cada caracter ocupa 16 bits)
            char meuChar = 'a';
            string meuString = "";
            Console.WriteLine("Meu caracter: " + meuChar);
            Console.WriteLine("Meu texto: " + meuString);

            // boolean e object
            // o tipo object é a origem de tudo (todos os outros se baseam nele, inclusive os primitivos)
            // as classes derivam de object
            // tem a capacidade de armazenar qualquer tipo de dado
            bool meuBool = true;
            object meuObjeto = "aceita um valor qualquer";
            Console.WriteLine("meu valor booleano é: " + meuBool);
            Console.WriteLine("meu valor do objeto é: " + meuObjeto);

            // constantes: sempre terá um valor (depois que armazena não muda)
            const uint porta = 27017;
            Console.WriteLine("O valor da porta do mongo é: " + porta);

            // realizando conversões (parse)
            string textoASerConvertido = "2018";
            uint numero;
            numero = uint.Parse(textoASerConvertido);
            Console.WriteLine("o valor do texto convertido em numero é: " + numero);

            // convertendo tipos numéricos utilizando o Convert
            // mesmo que o valor da variável seja compatível, é necessário realizar a conversão
            // o short na verdade é um int de 16 bits, int 32 e long 64
            // se o valor atribuído for maior o que vai acontecer é o truncate
            ulong numeroLongo = 113;
            ushort numeroCurto = System.Convert.ToUInt16(numeroLongo);
            Console.WriteLine("valor do número curto convertido é: " + numeroCurto);

            // introdução ao Array
            // pode armazenar qualquer tipo de dados (primitivos e personalizados)
            string[] nomes = {"Yuri", "Reis"};

            Console.WriteLine("Os nomes são: ");
            for (int i = 0; i < nomes.Length; i++)
            {
                Console.Write(nomes[i]);
            }

            // entrada de dados
            // Console.Read(): lê e retorna o valor ascii do caractere
            // Console.ReadKey(): lê o primeiro caractere digitado e retorna o valor do mesmo
            // Console.ReadLine(): lê a cadeia de caracteres digitados e retorna o valor da cadeia
        }
    }
}
