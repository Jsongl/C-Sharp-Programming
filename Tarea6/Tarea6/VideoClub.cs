using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea6
{
    public class VideoClub
    {

        public static List<Clase> Listado = new List<Clase>();

        public static void Agregar (Clase Nuevo)
        {
            Listado.Add(Nuevo);
        }

        public static void Eliminar (int posicion)
        {
            Listado.RemoveAt(posicion);
        }

        public static int BuscarTitulo (String Titulo)
        {
            int index=0;
            foreach(Clase temporal in Listado)
            {
                if (temporal.titulo == Titulo)
                    return index;
                index++;
            }
            return -1;
        }

        public static int BuscarCodigo (int Codigo)
        {
            int index=0;
            foreach(Clase temporal in Listado)
            {
                if (temporal.codigo == Codigo)
                    return index;
                index++;
            }
            return -1;
        }

        public static Clase RetornarRegistro (int index)
        {
            return (Listado.ElementAt(index));
        }

        public static void Modificar (int index, Clase Modificado)
        {
            Listado.RemoveAt(index);
            Listado.Insert(index, Modificado);
        }

        public static int Tamaño ()
        {
            return Listado.Count();
        }


        public static void prellenado ()
        {
            for (int counter = 1; counter <5; counter++)
            {
                Clase temporal = new Clase();

                temporal.codigo = counter;
                temporal.titulo = counter.ToString();
                temporal.ano = counter;
                temporal.calificacion = counter;
                temporal.clasificacion = counter.ToString();
                temporal.categoria = counter.ToString();

                Listado.Add(temporal);
             }
        }
    }
}
