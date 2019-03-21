using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio3
{
    class Program
    {
        static void Main(string[] args)
        {
            int num;
            Console.WriteLine("Ingrese un numero");
            num = int.Parse(Console.ReadLine());
            for(int i=1;i<num;i++)
            {
                if((i%2==0 && i!=2) || (i%3==0 && i!=3))
                {
                   Console.WriteLine("El numero no es primo: "+i);
                }
                else
                {
                    Console.WriteLine("El numero es primo: "+i);
                }
            }
            Console.ReadKey();
        }
    }
}
