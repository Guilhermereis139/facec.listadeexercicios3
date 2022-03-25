using System;

namespace Exercicio.Sete
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Informe seu nome:");
                string nome = Console.ReadLine();
                Console.WriteLine("Informe sua data de nascimento(dd/mm/aaaa):");
                DateTime nascimento = DateTime.Parse(Console.ReadLine());

                Console.WriteLine(ObterMensagemFaixaEtaria(nome, nascimento));
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            finally
            {
                Console.ReadLine();
            }
        }
        private static string ObterMensagemFaixaEtaria(string nome, DateTime nascimento)
        {
            var idade = DateTime.Today.Year - nascimento.Year;
            if (idade >= 60)
            {
                return $"Olá {nome}, está na faixa etária Idoso!";
            }
            else if (idade >= 20 && idade <= 59)
            {
                return $"Olá {nome}, está na faixa etária Adulto!";
            }
            else if (idade >= 0 && idade <= 19)
            {
                return $"Olá {nome}, está na faixa etária Jovem!";
            }

            return null;
        }
    }
}

