using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica_Sem7
{
    class Program
    {
        static int operacion(int x, int x2)
        {
            return (x + x2);
        }

        static int operacion(ref int x, int x2)
        {
            return (x - x2);
        }

        static int operacion(int x, ref int x2)
        {
            return (x * x2);
        }

        static int operacion(ref int x, ref int x2)
        {
            return (x / x2);
        }

        static void Main(string[] args)
        {
            int n1, n2;

            Console.Write("Numero 1: ");
            n1 = int.Parse(Console.ReadLine());

            Console.Write("Numero 2: ");
            n2 = int.Parse(Console.ReadLine());

            Console.WriteLine("\nSuma: {0}", operacion(n1, n2));
            Console.WriteLine("Resta: {0}", operacion(ref n1, n2));
            Console.WriteLine("Multiplicacion: {0}", operacion(n1, ref n2));
            Console.WriteLine("Division: {0}", operacion(ref n1, ref n2));

            Console.ReadKey();
        }
    }
}
