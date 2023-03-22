using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numero = 0;
            int decena = 0;
            int unidad = 0;
            Console.WriteLine("Ingrese un numero de dos cifras: ");
            numero = int.Parse(Console.ReadLine());
            unidad = numero % 10;
            decena = numero / 10;
            Console.WriteLine("La unidad = " + unidad);
            Console.WriteLine("La decena = " + decena);
            Console.WriteLine("El numero invertido es: " + unidad + decena);
            Console.ReadKey();

        }
    }
}
