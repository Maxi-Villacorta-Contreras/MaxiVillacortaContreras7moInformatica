using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EJERCICIOn10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float compra;
            float total;
            float totalf;
            Console.WriteLine("El total de la compra es:");
            compra = float.Parse(Console.ReadLine());
            total = (float)(compra * 0.15);
            totalf = (float)(compra - total);
            Console.WriteLine("El precio con el 15% de descuento es:" + totalf);
            Console.ReadKey();
        }
    }
}
