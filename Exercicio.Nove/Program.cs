using System;

namespace Exercicio.Nove
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(new Livro("Dois Irmãos", "Milton Hatoum", 99.90m).ToString());
            Console.ReadLine();
        }
    }
}