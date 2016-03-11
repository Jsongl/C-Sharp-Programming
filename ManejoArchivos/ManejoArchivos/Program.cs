using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ManejoArchivos
{
    class Program
    {
        /*EJEMPLO 6*/

        class Calculadora 
        {
            StreamReader sr; 
            bool abierto = false;
            
            // Constructor: Recibe el nombre del archivo y lo intenta abrir.
            // Si no puede abrirse para lectura, "abierto" queda como false 
            public Calculadora(string filename) {
                
                try {
                    sr = new StreamReader(filename); abierto = true;
                }
                catch(Exception e) {
                    Console.WriteLine("Error en la apertura de \"{0}\": {1}", filename,e.ToString());
                }

            }

            // Operacion: Recibe la operación y dos números en forma de string.
            // Retorna el resultado (int) de la operación entre ambos números. 
            
            int Operacion(string op, string n1, string n2) {

                switch(op) {
                    case "+": return( int.Parse(n1) + int.Parse(n2)); 
                    case "-": return( int.Parse(n1) - int.Parse(n2)); 
                    case "*": return( int.Parse(n1) * int.Parse(n2)); 
                    case "/": return( int.Parse(n1) / int.Parse(n2));
                }
            
                return(0);
            }

            // Procesar: lee líneas del archivo abierto, procesando el contenido en forma de operaciones.
            // Observaciones: al finalizar se cierra el stream. No se valida el formato de c/línea.
            public void Procesar() { 
                string linea;
                string[] elementos;
                
                if(!abierto) return; // Si no se pudo abrir, no hay nada que leer 
                linea = sr.ReadLine();
                
                while(linea != null) 
                {
                    // Para poder usar Split(), las operaciones y los operandos deben
                    // venir separados por espacios.
                    elementos = linea.Split();
                    Console.WriteLine("{0} = {1}", linea, Operacion(elementos[1], elementos[0], elementos[2])); 
                    linea = sr.ReadLine();
                }
                
                sr.Close(); 
                abierto = false;
            }
                
        }
                
            static void Main(string[] args)
            {
                string nombre; 
                //Console.Write("Nombre del archivo: ");
                nombre = "c:\\Test\\temp2.txt";
                Calculadora c = new Calculadora(nombre); c.Procesar();
                Console.ReadLine();
            }


        /*EJEMPLO 5
        static void Main(string[] args)
        {
            try
            {
                string fileName = "c:\\Test\\temp2.txt";
                // esto inserta texto en un archivo existente, si el archivo no existe lo crea
                StreamWriter writer = new StreamWriter (fileName, true); 
                writer.WriteLine("Este es el texto adicionado."); 
                writer.Close();
            }
            catch
            {
            Console.WriteLine("Error");
            }
        }
        */

        /*EJEMPLO 4
        static void Main(string[] args)
        {
            string fileName = "c:\\Test\\temp2.txt";
            FileStream stream = new FileStream(fileName, FileMode.OpenOrCreate, FileAccess.Write);
            StreamWriter writer = new StreamWriter(stream);
            writer.WriteLine("Esta es la primera línea del archivo."); 
            writer.Close();
        }
        */

        /*EJEMPLO 3
        class Archivo
        {
            StreamReader sr; 
            bool abierto = false;
        
            // Constructor: Recibe el nombre del archivo y lo abre (con control errores)
            public Archivo(string filename) 
            { 
                try {
                    sr = new StreamReader(filename); 
                    abierto = true;
                }
        
                catch(Exception e) {
                    Console.WriteLine("Error en la apertura de \"{0}\": {1}", filename, e.ToString());
                }
            }

            public void Mostrar() {
                string linea = "";
        
                if(!abierto) return; // Si no se pudo abrir, no hay nada que leer 
                linea = sr.ReadLine();
       
                while(linea != null) { // Lee líneas mientras haya (mientras sean !=null) 
                    Console.WriteLine(linea);
                    linea = sr.ReadLine();
                }
            
                sr.Close(); 
                abierto = false;
            }
        }
    
        static void Main(string[] args) { 
            string nombre;
        
            nombre = "c:\\Test\\temp.txt";
            Console.WriteLine("Nombre del archivo: {0}", nombre);

            Archivo archivo = new Archivo(nombre); 
            archivo.Mostrar();
            Console.ReadKey();
        }
        */

        
        /*EJEMPLO 2
        static void ReadFile(string sFileName) {
            
            
            if (File.Exists(sFileName)) 
            {
                FileStream fs = new FileStream(sFileName,FileMode.Open,FileAccess.Read, FileShare.ReadWrite);
                StreamReader sr = new StreamReader(fs);
                
                string sContent = sr.ReadToEnd();
                
                fs.Close();
                sr.Close();
                Console.Write("Contenido = " + sContent);
                Console.ReadKey();
            }
        }

        static void Main(string[] args)
        {
            string sPath = "c:\\Test\\";
            string sFileName = sPath + "temp.txt";
            ReadFile(sFileName);
        }
        */
        
        
        /*EJEMPLO 1
        static void Main(string[] args)
        {
            string fileName = "c:\\Test\\temp.txt";
            //FileStream stream = new FileStream(fileName, FileMode.Open,FileAccess.Read);
            StreamReader reader = new StreamReader(fileName);
            while (reader.Peek() > -1) Console.WriteLine(reader.ReadLine());
            reader.Close();
            Console.ReadKey();
        }
        */
    }
}
