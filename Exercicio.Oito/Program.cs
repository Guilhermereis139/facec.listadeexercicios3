using System;
using System.Linq;

namespace Exercicio.Oito
{
    class Program

    {
        private static readonly char[] _vogais = new char[]
        {
            'a', 'e', 'i', 'o','u'
        };
       // private const char _a = 'a';
       // private const char _e = 'e';
       //private const char _i = 'i';
        //private const char _o = 'o';
        //private const char _u = 'u';
        static void Main(string[] args)
        {
            

            try
            {

                Console.WriteLine("Informe o nome:");
                var nome = Console.ReadLine().ToLower();
                var count = 0;


                // for (int i = 0; i < nome.Length; i++)
                foreach (var Letra in nome)
                {
                   // var letra = nome[i];

                    // if (_a.Equals(letra)

                    //  && _e.Equals(nome[letra])
                    // && _i.Equals(nome[letra])
                    // && _o.Equals(nome[letra])
                    // && _u.Equals(nome[letra]))
                    if (!_vogais.Contains(Letra))
                        count++;
                }
                Console.WriteLine($"Seu nome possui {count} Consoantes!");
            }
            catch (Exception Ex)
            {
                Console.WriteLine(Ex.Message);
            }
            finally
            {
                Console.ReadLine();
            }

        }
    }
}