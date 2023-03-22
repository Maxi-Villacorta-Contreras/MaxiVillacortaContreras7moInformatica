using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio2_TP2._
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int dolar = 202;
            int euro = 213;
            int pesos = 0;
            int resultdolar = 0;
            int resulteuro = 0;
            Console.WriteLine("Ingrese una cantidad de pesos:");
            pesos = int.Parse(Console.ReadLine());
            resultdolar = pesos / dolar;
            resulteuro = pesos / euro;
            Console.WriteLine("El resultado del dolar es" + resultdolar);
            Console.WriteLine("El resultado del euro es" + resulteuro);
            Console.ReadKey();

        }
    }
}
