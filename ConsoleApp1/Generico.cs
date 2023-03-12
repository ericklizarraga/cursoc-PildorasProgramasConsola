using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntroCShark
{
    public class Generico<T>
    {
        public T []Array;
        private int contador = 0;

        public Generico(int tamano)
        {
            this.Array = new T[tamano];
        }

        public T getElemento(int i)
        {
            return Array[i];
        }


        public void insertElement(T elemento)
        {
            if( contador < Array.Length)
            {
                this.Array[contador] = elemento;
                contador++;
            }
            else
            {
                Console.WriteLine(" array lleno");
            }
        }
    }


    public class Persona
    {
        public string nombre { get; set; }
        public string apellido { get; set; }
        public string edad { get; set; }
    }
}
