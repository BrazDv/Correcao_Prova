using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class AvaliaçãoRestaurante
    {
        public void notaRestaurante()
        {

            double nota1, nota2, nota3, nota4;

            Console.WriteLine("Digite o valor da primeira nota");
            nota1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite o valor da segunda nota");
            nota2 = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite o valor da terceira nota");
            nota3 = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite o valor da quarta nota");
            nota4 = double.Parse(Console.ReadLine());

            double media = (nota1 + nota2 + nota3 + nota4) / 4;

            switch (media)
            {
                case double n when n >= 6:
                    Console.WriteLine("Aprovado");
                    break;
                default:
                    Console.WriteLine("Reprovado");
                    break;

            }
        }
    }
}
