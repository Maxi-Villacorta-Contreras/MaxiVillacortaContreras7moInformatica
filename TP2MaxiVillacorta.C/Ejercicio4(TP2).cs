using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio4_TP2_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num;
            int min;
            int hora;
            Console.WriteLine("Ingrese los segundos por teclado:");
            num = int.Parse(Console.ReadLine());
            min = num / 60;
            hora = num / 3600;
            Console.WriteLine("La cantidad de minutos es:" + min);
            Console.WriteLine("La cantidad de horas es:" + hora);
            Console.WriteLine("La cantidad de segundos es:" + num);
            Console.ReadKey();
        }
    }
}
