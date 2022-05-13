using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banco
{
    class Program
    {
        static void Main(string[] args)
        {
            
            int valor;
            int ced;
            int totalCed = 0;

            Console.Write("Insira um valor a ser sacado:");
            int resto = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Quais modelos de Nota deseja sacar:");
            ced = Int32.Parse(Console.ReadLine());
            valor = resto;
            while (true)
            {
                if (valor >= ced)
                {
                    valor = valor - ced;
                    totalCed = totalCed + 1;
                }
                else
                {
                    if (totalCed > 0)
                    {
                        Console.WriteLine($"Total de {totalCed} cedulas de R${ced}");
                    }
                    if (ced == 200)
                    {
                        ced = 100;
                    }
                    else if (ced == 100)
                    {
                        ced = 50;
                    }
                    else if (ced == 50)
                    {
                        ced = 20;
                    }
                    else if (ced == 20)
                    {
                        ced = 10;
                    }
                    else if (ced == 10)
                    {
                        ced = 5;
                    }
                    else if (ced == 5)
                    {
                        ced = 2;
                    }
                    totalCed = 0;
                    if (valor == 0)
                    {
                        break;
                    }
                }
            }
            Console.ReadLine();

        }
  
    }
}
