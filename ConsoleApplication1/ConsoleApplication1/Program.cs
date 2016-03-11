using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] lines = System.IO.File.ReadAllLines(@"C:\Test\file6.txt");

          
            System.Console.WriteLine("Words with N as 5th and S as 8th  ");
            foreach (string line in lines)
            {
                if (line[5] == 'S')
                    Console.WriteLine(line);
            }

            // Keep the console window open in debug mode.*/
            Console.WriteLine("Press any key to exit.");
            System.Console.ReadKey();
        }
    }
}
