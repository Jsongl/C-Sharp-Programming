using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea1
{
    class Program
    {
        static void Main(string[] args)
        {
            String nombre, autor;
            int precio, tipo, cantidad;

            Console.Write("Digite el nombre del libro: ");
            nombre = Console.ReadLine();

            Console.Write("Digite el nombre del autor: ");
            autor = Console.ReadLine();

            Console.Write("Digite el precio: ");
            precio = int.Parse(Console.ReadLine());

            Console.Write("Digite la cantidad: ");
            cantidad = int.Parse(Console.ReadLine());

            Console.WriteLine("\n1. Infantiles");
            Console.WriteLine("2. Misterio");
            Console.WriteLine("3. Fantasia");
            Console.WriteLine("4. Educativo");
            Console.Write("Digite el numero de la categoria: ");
            tipo = int.Parse(Console.ReadLine());

            Console.Clear();

            Console.WriteLine("\n\n***Resumen de la compra***\n");

            Console.WriteLine("Nombre del libro: {0}, {1}", nombre, autor);
            Console.Write("Descuento applicado: ");

            switch (tipo)
            {
                case 1: Console.WriteLine("20%"); Console.WriteLine("Total de la compra: {0}", (precio * cantidad) * (0.80)); break;
                case 2: Console.WriteLine("15%"); Console.WriteLine("Total de la compra: {0}", (precio * cantidad) * (0.85)); break;
                case 3: Console.WriteLine("10%"); Console.WriteLine("Total de la compra: {0}", (precio * cantidad) * (0.90)); break;
                default: Console.WriteLine("15%"); Console.WriteLine("Total de la compra: {0}", (precio * cantidad) * (0.85)); break;
            }


            Console.Write("\n\nDigite cualquier tecla....");
            Console.ReadKey();
        }
    }
}
