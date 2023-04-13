using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista1Ex8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double c;
            double f;

            // Entrada de Dados
            Console.WriteLine("0° graus Celsius equivalem a 32° graus Fahrenheit");
            Console.Write("Digite quantos graus Celsius deseja converter para Fahrenheit: ");
            c=double.Parse(Console.ReadLine());

            // Operação
            f = c * 1.8 + 32;

            Console.WriteLine("A conversão de {0}° Celsius para Fahrenheit é de {1}°",c,f);
        }
    }
}
