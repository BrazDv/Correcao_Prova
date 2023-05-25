using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Cardapio
    {
        public void Bocabraba()
        {
            int opcao;
            double quantidade, pesagem;

            Console.WriteLine("Cardápio Vaca Braba");
            Console.WriteLine(" '100' - Cupim = R$42,00");
            Console.WriteLine(" '101' - Picanha = R$37,30");
            Console.WriteLine(" '102' - Contra Filé = R$30,50");
            Console.WriteLine(" '103' - Linguiça = R$15,99");
            Console.WriteLine(" '104' - Costela = R$29,00");
            Console.WriteLine(" '105' - Wagyu = R$2870,00");
            Console.WriteLine("Escolha qual proteína deseja");
            opcao = int.Parse(Console.ReadLine());
          
            switch (opcao)
            {
                case 100:
                    Console.WriteLine("Escolha quantos kg você deseja levar");
                    quantidade = double.Parse(Console.ReadLine());
                    pesagem =quantidade * 42.00;
                    Console.WriteLine("Total a pagar " + pesagem.ToString("F2"));

                    break;

                case 101:
                    Console.WriteLine("Escolha quantos kg você deseja levar");
                    quantidade = double.Parse(Console.ReadLine());
                    pesagem = quantidade * 37.30;
                    Console.WriteLine("Total a pagar " + pesagem.ToString("F2"));

                    break;
                case 102:
                    Console.WriteLine("Escolha quantos kg você deseja levar");
                    quantidade = double.Parse(Console.ReadLine());
                    pesagem = quantidade * 30.50;
                    Console.WriteLine("Total a pagar " + pesagem.ToString("F2"));

                    break;
                case 103:
                    Console.WriteLine("Escolha quantos kg você deseja levar");
                    quantidade = double.Parse(Console.ReadLine());
                    pesagem = quantidade * 15.99;
                    Console.WriteLine("Total a pagar " + pesagem.ToString("F2"));

                    break;
                case 104:
                    Console.WriteLine("Escolha quantos kg você deseja levar");
                    quantidade = double.Parse(Console.ReadLine());
                    pesagem = quantidade * 29.00;
                    Console.WriteLine("Total a pagar " + pesagem.ToString("F2"));

                    break;
                case 105:
                    Console.WriteLine("Escolha quantos kg você deseja levar");
                    quantidade = double.Parse(Console.ReadLine());
                    pesagem = quantidade * 2870.00;
                    Console.WriteLine("Total a pagar " + pesagem.ToString("F2"));

                    break;

                default:
                    Console.WriteLine("Escolha novamente uma carne na qual trabalhamos!...");

                    break;
            }
        }   
    }
}
