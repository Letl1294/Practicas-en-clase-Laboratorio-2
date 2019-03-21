using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio2
{
    class Program
    {
        static void Main(string[] args)
        {
            int num;
            double cuadrado= 0, cubo;
            Console.WriteLine("Ingrese un Numero");
            num = int.Parse(Console.ReadLine());
            while (num<=0)
            {
                Console.WriteLine("Error.Reingrese Numero");
                num = int.Parse(Console.ReadLine());
            }
            cuadrado = Math.Pow(num,2);
            cubo = Math.Pow(num,3);
            Console.WriteLine("Cuadrado: "+cuadrado);
            Console.WriteLine("Cubo: "+cubo);
            Console.ReadKey();
        }
    }
}
