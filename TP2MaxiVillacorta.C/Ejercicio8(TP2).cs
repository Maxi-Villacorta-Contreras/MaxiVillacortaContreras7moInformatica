using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float fahrenheit;
            float celsius;
            Console.WriteLine("Los grados fahrenheit son:");
            fahrenheit = float.Parse(Console.ReadLine());
            celsius = (float)(fahrenheit - 32 / 1.8);
            Console.WriteLine("Los gados celsius son:" + celsius);
            Console.ReadKey(); 
            
        }
    }
}
