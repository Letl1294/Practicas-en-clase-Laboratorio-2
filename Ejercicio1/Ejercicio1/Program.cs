using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio1
{
    class Program
    {
        static void Main(string[] args)
        {
            int num=0;
            int acum = 0;
            int max = int.MaxValue;
            int min = int.MinValue;
            int prom = 0;
            Console.Title = "Ejercicio 1";  
            for(int i=0;i<5;i++)
            {
                Console.WriteLine("Ingrese un Numero");
                num = int.Parse(Console.ReadLine());
                if (i==0)
                {
                    min = num;
                    max = num;
                }
                if(i>0 && num<min)
                {
                    min = num;
                }
                if(i>0 && num>max)
                {
                    max = num;
                }
                acum = num + acum; 
            }
            prom = acum / 5;
            Console.WriteLine("Maximo: "+max);
            Console.WriteLine("Minimo: "+min);
            Console.WriteLine("Promedio: " + prom);
            Console.ReadKey();
        }
    }
}
