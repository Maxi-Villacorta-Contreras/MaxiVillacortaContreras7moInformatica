using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio14
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int hora;
            int min;
            int seg;
            int duraV;
            int auxseg;
            int segR;
            Console.WriteLine("Ingrese la hora de salida de la ciudad A: ");
            hora = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese los minutos de salida d la ciudad A: ");
            min = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese los segundos de salida de la ciudad A: ");
            seg = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese la duracion del viaje a la ciudad B: ");
            duraV = int.Parse(Console.ReadLine());
            auxseg = hora * 3600 + min * 60 + seg + duraV;
            hora = auxseg / 3600;
            segR = (int)Math.IEEERemainder(auxseg, 3600);
            min = segR / 60;
            seg = (int)Math.IEEERemainder(segR, 60);
            hora = Math.Abs(hora);
            min = Math.Abs(min);
            seg = (int)Math.Abs(seg);
            Console.WriteLine("La hora de llegada a la ciudad B es: " + hora + ";" + min + ";" + seg);
            Console.ReadKey();



        }
    }
}
