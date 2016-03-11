using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ExamenPractica2
{
    class Program
    {
        static void Main(string[] args)
        {
            int opcion = 0;
            string nombrearchivo = "c:\\test.txt";

            while (opcion != 4)
            {
                Console.Clear();

                Console.WriteLine("**********************");
                Console.WriteLine("  Manejo de archivos  ");
                Console.WriteLine("**********************\n");
                Console.WriteLine(" 1. Crear archivo");
                Console.WriteLine(" 2. Agregar 5 lineas");
                Console.WriteLine(" 3. Imprimir archivo");
                Console.WriteLine(" 4. Salir");

                Console.Write("\n\nDigite la opcion: ");
                opcion = int.Parse(Console.ReadLine());

                switch (opcion)
                {
                    case 1:
                        creararchivo(nombrearchivo);
                        break;
                    case 2:
                        agregarlineas(nombrearchivo);
                        break;
                    case 3:
                        imprimirarchivo(nombrearchivo);
                        break;
                    case 4:
                        File.Delete(nombrearchivo);
                        break;
                    default: break;
                }
            }
        }

        static void creararchivo(string nombrearchivo)
        {
            //File.Create(nombrearchivo);
            StreamWriter archivo = new StreamWriter(nombrearchivo);
            archivo.Close();

        }

        static void agregarlineas(string nombrearchivo)
        {
            StreamWriter archivo = new StreamWriter(nombrearchivo,true);

            for (int x = 1; x <= 5; x++)
                archivo.WriteLine("Linea {0}", x);

            archivo.Close();
        }

        static void imprimirarchivo(string nombrearchivo)
        {
            String lineaimprimir;
            StreamReader archivo = new StreamReader(nombrearchivo);

            Console.Clear();

            Console.WriteLine("Contenido del archivo:\n\n");

            Console.WriteLine("********************************************");
            lineaimprimir = archivo.ReadLine();
            while (lineaimprimir != null)
            {
                Console.WriteLine(lineaimprimir);
                lineaimprimir = archivo.ReadLine();
            }
            Console.WriteLine("********************************************");

            archivo.Close();

            Console.Write("\n\nFin del archivo, digite cualquier tecla.......");
            Console.ReadKey();
        }
    }
}
