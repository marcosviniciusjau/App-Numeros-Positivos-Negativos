using System;

namespace PareImpar
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {



            } catch (Exception ex)
            {

            }
            double numero_qualquer;

            Console.WriteLine("Digite um número qualquer");
            numero_qualquer = Convert.ToDouble(Console.ReadLine());

            if (numero_qualquer > 0)
        }
            Console.WriteLine("Você digitou um número positivo");

        }  else if(numero_qualquer < 0)
            Console.WriteLine("Você digitou um número negativo");

        } else /*if(numero_qualquer ==0)*/
          Console.WriteLine("Você digitou zero.");
        }
    }
}
