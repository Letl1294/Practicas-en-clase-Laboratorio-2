using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio4
{
    class Program
    {
        static void Main(string[] args)
        {
            int acum=0, contador=0;
            int i=1;
            while(contador<4)
            {
                acum = 0;
                for (int j=1;j<i;j++)
                {
                    if(i%j==0 && i!=j)
                    {
                        acum = j + acum;
                    }
                }
                if(acum==i)
                {
                    Console.WriteLine("Numero Perfecto: " + acum);
                    contador++;
                }
                i++;
            }
            Console.ReadKey();
        }
    }
}
