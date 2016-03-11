using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenPractica1
{
    class Program
    {
        static void Main(string[] args)
        {
            String cadena;
            Char[] listacadena;
            int contador = 0, contador2;

            Console.Write("Digite la cadena: ");

            cadena = Console.ReadLine();

            listacadena = cadena.ToCharArray();

            Console.WriteLine("\n\nLista de caracteres de izquierda a derecha:");
            foreach (char imp in listacadena)
            {
                Console.Write("[{0}]  ", imp);
                contador++;
            }

            Console.WriteLine("\n\nLista de caracteres de derecha a izquierda:");
            if (contador >= 0)
                for (contador2 = contador - 1; contador2 >= 0; contador2--)
                {
                    Console.Write("[{0}]  ", listacadena[contador2]);
                }

            contador2 = 0;
            contador--; 

            while ((listacadena[contador2] == listacadena[contador]) && contador >= contador2)
            {
                contador2++;
                contador--;
            }

            if (contador2 > contador)
                Console.WriteLine("\n\nEl arreglo es palindromo.");
            else
                Console.WriteLine("\n\nEl arreglo no es palindromo.");
            

            Console.ReadKey();
        }
    }
}
