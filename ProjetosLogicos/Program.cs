using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetosLogicos
{
    class Program
    {
        static void Main(string[] args)
        {
            double num1, num2, resultado;
            char operador;

            Console.WriteLine("Infome o um número");
            num1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Informe o operador desejado");
            operador = Convert.ToChar(Console.ReadLine());
            Console.WriteLine("Informe um segundo número");
            num2 = Convert.ToDouble(Console.ReadLine());

            if (operador == '+')
            {
                resultado = num1 + num2;
                Console.WriteLine(resultado);
            }
            else if (operador == '-')
            {
                resultado = num1 - num2;
                Console.WriteLine(resultado);
            }
            else if (operador == '/')
            {
                resultado = num1 / num2;
                Console.WriteLine(resultado);
            }
            else
            {
                resultado = num1 * num2;
                Console.WriteLine(resultado);
            }
            Console.ReadLine();
        }
    }
}
