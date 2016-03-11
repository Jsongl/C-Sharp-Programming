using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea2
{
    class Program
    {
        static void Main(string[] args)
        {
            int opcion;

            do
            {
                Console.Clear();

                Console.WriteLine("  Menu Principal");
                Console.WriteLine("******************\n");
                Console.WriteLine("1. Retiro de dinero");
                Console.WriteLine("2. Recibo de monedas");
                Console.WriteLine("3. Consulta de tipo de cambio");
                Console.WriteLine("4. Salir\n");


                Console.Write("Digite la opcion: ");
                opcion = int.Parse(Console.ReadLine());

                switch (opcion)
                {
                    case 1: calcular_retirodinero(); break;
                    case 2: calcular_recibomonedas(); break;
                    case 3: calcular_tipodecambio();  break;
                    default: break;
                }

            } while (opcion != 4);
        }


        static void calcular_tipodecambio()
        {
            int tipocambio, cantidad, tipo;

            Console.Clear();

            Console.Write("Digite el tipo de cambio del dia: ");
            tipocambio = int.Parse(Console.ReadLine());

            Console.WriteLine("\n\nDigite el numero conversion desea hacer: ");
            Console.WriteLine("\t1. Colones -> Dolares");
            Console.WriteLine("\t2. Dolares -> Colones");
            Console.Write("Respuesta: ");
            tipo = int.Parse(Console.ReadLine());

            Console.Write("\n\nCantidad a convertir: ");
            cantidad = int.Parse(Console.ReadLine());

            if (tipo == 1)
            {
                Console.WriteLine("\n\n{0} Colones son equivalentes a {1} Dolares.", cantidad, (cantidad / tipocambio));
            }
            else
            {
                Console.WriteLine("\n\n{0} Dolares son equivalentes a {1} Colones.", cantidad, (cantidad * tipocambio));
            }

            Console.WriteLine("\n\nDigite cualquier tecla para continuar....");
            Console.ReadKey();
        }

        static void calcular_recibomonedas()
        {
            int respuesta;
            int[] monedas = {0,0,0,0,0,0};
            int totalmon =0, total = 0, monto;

            do
            {
                Console.Clear();

                Console.Write("Digite el monto de la moneda: ");
                monto = int.Parse(Console.ReadLine());

                if (monto == 5)
                {
                    totalmon++;
                    total = total + 5;
                    monedas[0] = monedas[0] + 5;
                }
                else if (monto == 10)
                {
                    totalmon++;
                    total = total + 10;
                    monedas[1] = monedas[1] + 10;
                }
                else if (monto == 25)
                {
                    totalmon++;
                    total = total + 25;
                    monedas[2] = monedas[2] + 25;
                }
                else if (monto == 50)
                {
                    totalmon++;
                    total = total + 50;
                    monedas[3] = monedas[3] + 50;
                }
                else if (monto == 100)
                {
                    totalmon++;
                    total = total + 100;
                    monedas[4] = monedas[4] + 100;
                }
                else if (monto == 500)
                {
                    totalmon++;
                    total = total + 500;
                    monedas[5] = monedas[5] + 500;
                }
                else
                {
                    Console.WriteLine("\n\nMonto de moneda invalido...");
                    Console.WriteLine("Intente de nuevo....");
                    Console.ReadKey();
                }


                Console.Write("\nDesea insertar otra moneda (1. Si / 0. No): ");
                respuesta = int.Parse(Console.ReadLine());
            } while (respuesta == 1 && totalmon < 50);

            Console.Clear();

            Console.WriteLine("Total de monedas: {0}",totalmon);
            Console.WriteLine("Total recibido: {0}",total);

            Console.WriteLine("\nTotal por monedas: ");
            Console.WriteLine("5: {0}", monedas[0]);
            Console.WriteLine("10: {0}", monedas[1]);
            Console.WriteLine("25: {0}", monedas[2]);
            Console.WriteLine("50: {0}", monedas[3]);
            Console.WriteLine("100: {0}", monedas[4]);
            Console.WriteLine("500: {0}", monedas[5]);

            Console.WriteLine("\n\nDigite cualquier tecla para continuar....");
            Console.ReadKey();
        }

        static void calcular_retirodinero()
        {
            int monto, montotemp;
            int[] billetes = {0,0,0,0};

            do
            {
                Console.Clear();

                Console.Write("Digite la cantidad a retirar: ");
                monto = int.Parse(Console.ReadLine());

                if (monto % 1000 != 0)
                {
                    Console.WriteLine("\nMonto debe ser multiplos de 1000.");
                    Console.WriteLine("Intente de nuevo....");
                    Console.ReadKey();
                }
            } while (monto % 1000 != 0);

            montotemp = monto;

            if (montotemp >= 10000)
            {
                billetes[0]= montotemp / 10000;
                montotemp= montotemp % 10000;
            }
            if (montotemp >= 5000)
            {
                billetes[1]= montotemp / 5000;
                montotemp= montotemp % 5000;
            }
            if (montotemp >= 2000)
            {
                billetes[2]= montotemp / 2000;
                montotemp= montotemp % 2000;
            }
            if (montotemp >= 1000)
            {
                billetes[3]= montotemp / 1000;
                montotemp= montotemp % 1000;
            }


            Console.Clear();
            Console.WriteLine("Cantidad de billetes a dispensar\n");
            Console.WriteLine("\t10000: {0}", billetes[0]);
            Console.WriteLine("\t5000: {0}", billetes[1]);
            Console.WriteLine("\t2000: {0}", billetes[2]);
            Console.WriteLine("\t1000: {0}", billetes[3]);

            Console.WriteLine("\n\nDigite cualquier tecla....");
            Console.Read();
        }
    }
}

