using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntroCShark
{
    public class EjemploFinally
    {
        public EjemploFinally()
        {
            System.IO.StreamReader file = null;

            try
            {
                string linea;
                int contador= 0;
                string path = @"d:\erick\curso html y mas\aspcore\juanpildoras\consoleapp1\consoleapp1\tirar.txt";
                file = new System.IO.StreamReader( path );

                while ( ( linea = file.ReadLine() ) != null )
                { 
                    Console.WriteLine( linea );
                    contador++;
                }
            }catch (Exception ex)
            {
                Console.WriteLine("error con la lectura de archivo");
            }
            finally
            {
                if ( file != null ) file.Close();
                Console.WriteLine("conexion cerrada con el fichero");
            }
        }
    }
}
