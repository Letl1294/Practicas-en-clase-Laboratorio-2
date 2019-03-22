using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int num;
            Console.WriteLine("Ingrese un numero: ");
            num = int.Parse(Console.ReadLine());
            for (int i = 1; i < num; i++)
            {
                if(esCentroNumerico(i))
                {
                    Console.WriteLine("Centro numerico: "+i);
                }
            }
            Console.ReadKey();
        }
        static bool esCentroNumerico(int numero)
        {
            int minimo;
            bool centroNum;
            minimo = sumaMinima(numero);
            centroNum = sumaMaxima(numero,minimo);
            return centroNum;
        }
        static int sumaMinima(int numero)
        {
            int acum = 0;
            for (int i = 1; i < numero; i++)
                acum = acum + i;
            return acum;
        }
        static bool sumaMaxima(int numero, int minimo)
        {
            int acum = 0;
            int i = numero+1;
            while (acum < minimo)
            {
                acum = acum + i;
                if (acum == minimo)
                {
                    return true;
                }
                i++;
            }
            return false;
        }
    }
}