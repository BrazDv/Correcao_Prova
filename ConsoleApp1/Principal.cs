using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Principal
    {
        public static void Main()
        {
            int opcao;
            do
            {
                Console.WriteLine("(1) Cardapio");
                Console.WriteLine("(2) SalárioGarçons");
                Console.WriteLine("(3) AvaliaçãoRestaurante");
                Console.WriteLine("(0) Sair");
                    opcao = int.Parse(Console.ReadLine());
                switch(opcao)
                {
                    case 1:
                        Cardapio Slct1 = new Cardapio();
                        Slct1.Bocabraba();
                        break;
                    case 2:
                        SalárioGarçons Slct2 = new SalárioGarçons();
                        Slct2.salário();
                        break;
                    case 3:
                        AvaliaçãoRestaurante Slct3 = new AvaliaçãoRestaurante();
                        Slct3.notaRestaurante();
                        break;
                }
            } while (opcao != 0);
        }     

    }
}
