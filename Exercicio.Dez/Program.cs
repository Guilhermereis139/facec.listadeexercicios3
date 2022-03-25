using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio.Dez
{
    public abstract class AbstractAluno
    {
        public abstract string ObterNome();

        public abstract string ObterRa();

        public abstract int ObterNota();

        public abstract int ObterFalta();

        public string Frequencia()
        {
            int freq = ObterFalta();
            if (freq <= 10)
            {
                return $"Você teve {ObterFalta()} faltas: APROVADO!";
            }
            else
            {
                return $"Você teve {ObterFalta()} faltas: REPROVADO!";
            }
        }
        public string NotasMedia()
        {
            int nota = ObterFalta();
            if (nota <= 70)
            {
                return $"Sua média foi {ObterNota()} : APROVADO!";
            }
            else
            {
                return $"Sua média foi {ObterNota()} : REPROVADO!";
            }
        }

        public virtual string ImprimirDados()
        {
            return $"Nome: {ObterNome()} RA: {ObterRa()} \n" +
                $"{Frequencia()} \n" +
                $"{NotasMedia()} \n";
        }
    }
}