using System;

namespace CondicionalMaiorNumero
{
    class Program
    {
        static void Main(string[] args)
        {
            double numero1, numero2, numero3;
            Console.WriteLine("Digite 3 números aleatórios e descubra qual é o maior entre eles:");
            numero1 = double.Parse(Console.ReadLine());
            numero2 = double.Parse(Console.ReadLine());
            numero3 = double.Parse(Console.ReadLine());

            if (numero1 > numero2 && numero1 > numero3)
            {
                Console.WriteLine(numero1);
            }
            else if (numero2 > numero1 && numero2 > numero3)
            {
                Console.WriteLine(numero2);
            }
            else
            {
                Console.WriteLine(numero3);
            }
        }
    }
}