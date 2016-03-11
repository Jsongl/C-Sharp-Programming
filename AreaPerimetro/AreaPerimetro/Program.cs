using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AreaPerimetro
{
    class Program
    {
        static void Main(string[] args)
        {
            int opcionprincipal = 0;

            do
            {
                Console.Clear();
                Console.WriteLine("*************************************");
                Console.WriteLine("****Calculadora de area/perimetro****");
                Console.WriteLine("*************************************\n");

                Console.WriteLine("1. Cuadrado");
                Console.WriteLine("2. Rectangulo");
                Console.WriteLine("3. Triangulo");
                Console.WriteLine("4. Circulo");
                Console.WriteLine("5. Salir");

                Console.Write("\n\nDigite la opcion: ");

                opcionprincipal = int.Parse(Console.ReadLine());

                switch (opcionprincipal)
                {
                    case 1: MenuCuadrado(); break;
                    case 2: MenuRectangulo(); break;
                    case 3: MenuTriangulo(); break;
                    case 4: MenuCirculo(); break;
                    default: break;
                }

            } while (opcionprincipal != 5);

        }


        static void MenuCuadrado()
        {
            int opcion = 0, resultado, lado;

            while (opcion != 4)
            {
                Console.Clear();
                Console.Write("Digite la medida del lado: ");

                lado = int.Parse(Console.ReadLine());

                do
                {
                    Console.Clear();

                    Console.WriteLine("****************");
                    Console.WriteLine("****Cuadrado****");
                    Console.WriteLine("****************\n");

                    Console.WriteLine("1. Area");
                    Console.WriteLine("2. Perimetro");
                    Console.WriteLine("3. Introducir datos de nuevo");
                    Console.WriteLine("4. Salir");

                    Console.Write("\nDigite la opcion: ");

                    opcion = int.Parse(Console.ReadLine());

                    switch (opcion)
                    {
                        case 1:
                            resultado = lado * lado;
                            Console.WriteLine("\n\nEl area del cuadrado es: {0}", resultado);
                            Console.Write("\n\nDigite Cualquier tecla para continuar...");
                            Console.ReadKey();
                            break;
                        case 2:
                            resultado = lado * 4;
                            Console.WriteLine("\n\nEl perimetro del cuadrado es: {0}", resultado);
                            Console.Write("\n\nDigite Cualquier tecla para continuar...");
                            Console.ReadKey();
                            break;
                        default: break;
                    }
                } while (opcion != 4 && opcion != 3);
            }
        }


        static void MenuRectangulo()
        {
            int opcion = 0, resultado, lado, lado2;

            while (opcion != 4)
            {
                Console.Clear();
                Console.Write("Digite la medida del largo: ");
                lado = int.Parse(Console.ReadLine());

                Console.Write("Digite la medida del ancho: ");
                lado2 = int.Parse(Console.ReadLine());

                do
                {
                    Console.Clear();

                    Console.WriteLine("****************");
                    Console.WriteLine("****Rectangulo****");
                    Console.WriteLine("****************\n");

                    Console.WriteLine("1. Area");
                    Console.WriteLine("2. Perimetro");
                    Console.WriteLine("3. Introducir datos de nuevo");
                    Console.WriteLine("4. Salir");

                    Console.Write("\nDigite la opcion: ");

                    opcion = int.Parse(Console.ReadLine());

                    switch (opcion)
                    {
                        case 1:
                            resultado = lado * lado2;
                            Console.WriteLine("\n\nEl area del rectangulo es: {0}", resultado);
                            Console.Write("\n\nDigite Cualquier tecla para continuar...");
                            Console.ReadKey();
                            break;
                        case 2:
                            resultado = (lado + lado2) * 2;
                            Console.WriteLine("\n\nEl perimetro del rectangulo es: {0}", resultado);
                            Console.Write("\n\nDigite Cualquier tecla para continuar...");
                            Console.ReadKey();
                            break;
                        default: break;
                    }
                } while (opcion != 4 && opcion != 3);
            }
        }


        static void MenuTriangulo()
        {
            int opcion = 0, lado, lado2, lado3, semiperimetro;
            double resultado;

            while (opcion != 4)
            {
                Console.Clear();
                Console.Write("Digite la medida del lado 1: ");
                lado = int.Parse(Console.ReadLine());

                Console.Write("Digite la medida del lado 2: ");
                lado2 = int.Parse(Console.ReadLine());

                Console.Write("Digite la medida del lado 3: ");
                lado3 = int.Parse(Console.ReadLine());

                semiperimetro = (lado + lado2 + lado3) / 2;

                do
                {
                    Console.Clear();

                    Console.WriteLine("****************");
                    Console.WriteLine("****Triangulo****");
                    Console.WriteLine("****************\n");

                    Console.WriteLine("1. Area");
                    Console.WriteLine("2. Perimetro");
                    Console.WriteLine("3. Introducir datos de nuevo");
                    Console.WriteLine("4. Salir");

                    Console.Write("\nDigite la opcion: ");

                    opcion = int.Parse(Console.ReadLine());

                    switch (opcion)
                    {
                        case 1:
                            resultado = Math.Sqrt(semiperimetro * (semiperimetro - lado) * (semiperimetro - lado2) * (semiperimetro - lado3));
                            Console.WriteLine("\n\nEl area del triangulo es: {0}", resultado);
                            Console.Write("\n\nDigite Cualquier tecla para continuar...");
                            Console.ReadKey();
                            break;
                        case 2:
                            resultado = semiperimetro * 2;
                            Console.WriteLine("\n\nEl perimetro del triangulo es: {0}", resultado);
                            Console.Write("\n\nDigite Cualquier tecla para continuar...");
                            Console.ReadKey();
                            break;
                        default: break;
                    }
                } while (opcion != 4 && opcion != 3);
            }
        }


        static void MenuCirculo()
        {
            int opcion = 0, lado;
            double resultado;

            while (opcion != 4)
            {
                Console.Clear();
                Console.Write("Digite la medida del radio: ");
                lado = int.Parse(Console.ReadLine());

                do
                {
                    Console.Clear();

                    Console.WriteLine("****************");
                    Console.WriteLine("****Circulo****");
                    Console.WriteLine("****************\n");

                    Console.WriteLine("1. Area");
                    Console.WriteLine("2. Circunferencia");
                    Console.WriteLine("3. Introducir datos de nuevo");
                    Console.WriteLine("4. Salir");

                    Console.Write("\nDigite la opcion: ");

                    opcion = int.Parse(Console.ReadLine());

                    switch (opcion)
                    {
                        case 1:
                            resultado = 3.1415 * (lado * lado);
                            Console.WriteLine("\n\nEl area del circulo es: {0}", resultado);
                            Console.Write("\n\nDigite Cualquier tecla para continuar...");
                            Console.ReadKey();
                            break;
                        case 2:
                            resultado = 3.1415 * (lado + lado);
                            Console.WriteLine("\n\nLa Circunferencia del triangulo es: {0}", resultado);
                            Console.Write("\n\nDigite Cualquier tecla para continuar...");
                            Console.ReadKey();
                            break;
                        default: break;
                    }
                } while (opcion != 4 && opcion != 3);
            }
        }
    }
}
