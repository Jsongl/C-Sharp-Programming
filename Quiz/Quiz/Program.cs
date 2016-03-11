using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quiz
{
    class Program
    {
        static double[] areas_tri = new double[3];
        static double[] perimetros_tri = new double[3];

        static double[] areas_cir = new double[3];
        static double[] perimetros_cir = new double[3];

        static int hombres = 0;
        static int mujeres = 0;
        static int[] clasificacion = {0,0,0,0};

        static void Main(string[] args)
        {
            int opcion = 0;

            do 
            {
                Console.Clear();

                Console.WriteLine("**************");
                Console.WriteLine("  MENU QUIZ");
                Console.WriteLine("**************");

                Console.WriteLine("1. Triangulo");
                Console.WriteLine("2. Circulo");
                Console.WriteLine("3. Mostrar resultado");
                Console.WriteLine("4. Lectura de estudiantes");
                Console.WriteLine("5. Resultados de censo");
                Console.WriteLine("6. Salir");

                Console.Write("\nDigite la opcion: ");
                opcion = int.Parse(Console.ReadLine());

                switch (opcion)
                {
                    case 1: CalculoTriangulo(); break;
                    case 2: CalculoCirculo(); break;
                    case 3: MostrarResultados(); break;
                    case 4: LecturaEstudiantes(); break;
                    case 5: ImprimirEstadisticas(); break;
                    default: break;
                }

            } while (opcion !=6);

        }

        static void LecturaEstudiantes()
        {
            string nombre;
            int edad, sexo, contador;

            for (contador = 1; contador <= 3; contador++)
            {
                Console.Clear();
                Console.WriteLine("Lectura de estudiante {0}\n", contador);
                Console.Write("Digite nombre: ");
                nombre = Console.ReadLine();

                Console.Write("Digite la edad: ");
                edad = int.Parse(Console.ReadLine());

                Console.Write("Digite sexo (1.Masculino o 2.Femenino): ");
                sexo = int.Parse(Console.ReadLine());

                if (sexo == 1)
                    hombres++;
                else
                    mujeres++;

                if (edad <= 15)
                    clasificacion[0]++;
                else if (edad >= 16 && edad <= 25)
                    clasificacion[1]++;
                else if (edad >= 26 && edad <= 55)
                    clasificacion[2]++;
                else
                    clasificacion[3]++;
            }

            Console.Clear();
            Console.WriteLine("Se finalizo la lectura de los 10 registro.");
            Console.WriteLine("\n\nDigite cualquier tecla para volver al menu.....");
        }

        static void ImprimirEstadisticas()
        {
            Console.Clear();

            Console.WriteLine("Estadisticas\n");
            Console.WriteLine("Cantidad de hombres: {0}", hombres);
            Console.WriteLine("Cantidad de mujeres: {0}", mujeres);

            Console.WriteLine("\nNiños: {0}", clasificacion[0]);
            Console.WriteLine("Jovenes: {0}", clasificacion[1]);
            Console.WriteLine("Adultos: {0}", clasificacion[2]);
            Console.WriteLine("Adultos Mayores: {0}", clasificacion[3]);

            Console.WriteLine("\nDigite cualquier tecla....");
            Console.ReadKey();
        }

        static void CalculoTriangulo ()
        {
            int contador = 1;
            double basel, altura;

            for (contador = 1; contador <= 3; contador++)
            {
                Console.Clear();

                Console.WriteLine("Datos del triangulo {0}\n", contador);

                Console.Write("Digite la altura: ");
                altura = int.Parse(Console.ReadLine());

                Console.Write("Digite la base: ");
                basel = int.Parse(Console.ReadLine());

                areas_tri[contador - 1] = (basel * altura) / 2;
                perimetros_tri[contador - 1] = basel * 3;
            }
        }

        static void CalculoCirculo()
        {
            int contador = 1;
            double radio = 0.0;

            for (contador = 1; contador <= 3; contador++)
            {
                Console.Clear();

                Console.WriteLine("Datos del circulo {0}\n", contador);

                Console.Write("Digite el radio: ");
                radio = int.Parse(Console.ReadLine());

                areas_cir[contador - 1] = (3.14 * radio) * (3.14 * radio);
                perimetros_cir[contador - 1] = (3.14 * radio);
            }
        }

        static void MostrarResultados()
        {
            int contador;

            Console.Clear();

            if (areas_tri[0]==0)
            {
                Console.WriteLine("No se han leido los datos de triangulos.");
                Console.WriteLine("\n\nDigite cualquier tecla para volver al menu.....");
                Console.ReadKey();
            }
            else if (areas_cir[0] == 0)
            {
                Console.WriteLine("No se han leido los datos de circulos.");
                Console.WriteLine("\n\nDigite cualquier tecla para volver al menu.....");
                Console.ReadKey();
            }
            else
            {
                Console.WriteLine("Resultados de los calculos\n");

                Console.WriteLine("Triangulos");
                for (contador = 0; contador <= 2; contador++)
                {
                    Console.WriteLine("\tTriangulo {0}:", contador + 1);
                    Console.WriteLine("\t\tArea: {0}", areas_tri[contador]);
                    Console.WriteLine("\t\tPerimetro: {0}", perimetros_tri[contador]);
                }

                Console.WriteLine("\nCirculos");
                for (contador = 0; contador <= 2; contador++)
                {
                    Console.WriteLine("\tCirculo {0}:", contador + 1);
                    Console.WriteLine("\t\tArea: {0}", areas_tri[contador]);
                    Console.WriteLine("\t\tPerimetro: {0}", perimetros_tri[contador]);
                }

                Console.Write("\nDigite cualquier tecla para continuar...");
                Console.ReadKey();
            }
        }
    }
}
