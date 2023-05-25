using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class SalárioGarçons
    {
        public void salário()
        {
            int qtdSalario;
            double valorsalario, horas;
            
            Console.WriteLine("Garçon '1'");
            Console.WriteLine("Garçon '2'");
            Console.WriteLine("Garçon '2'");
            Console.WriteLine("Escolha qual garçon");
            qtdSalario = int.Parse(Console.ReadLine());
            switch(qtdSalario)
            {
                case 1:
                    Console.WriteLine("Horas trabalhadas");
                    horas = double.Parse(Console.ReadLine());
                    valorsalario = horas * 25.00;
                    break;
                case 2:
                    Console.WriteLine("Horas trabalhadas");
                    horas = double.Parse(Console.ReadLine());
                    valorsalario = horas * 50.00;
                    break;
                case 3:
                    Console.WriteLine("Horas trabalhadas");
                    horas = double.Parse(Console.ReadLine());
                    valorsalario = horas * 100.00;
                    break;
                default:
                    Console.WriteLine("Valor inválido");
                    break;
            }


        }
    }
}