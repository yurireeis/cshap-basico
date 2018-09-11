using System;

namespace Comentarios
{
    class Program
    {
        static void Main(string[] args)
        {
            // comentários não são inseridos na compilação
            /*
              esse é um comentário multilinha
              comentários com barra tripla (///) e a tag summary (<summary>) servem para documentar
              métodos/propriedades

              também temos o comentário TODO que marca tarefas a serem executadas futuramente
             */
             Example();
        }
        
        /// <summary>
        /// testando... tente instanciar o método estático example e veja
        /// se esse texto irá aparecer
        /// </summary>
        public static void Example() => Console.WriteLine("Veja se este método está documentado!");

        // TODO: implementar o código do método abaixo futuramente
        public static void ToDoExample() { }
    }
}
