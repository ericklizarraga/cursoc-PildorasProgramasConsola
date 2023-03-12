using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Delegados
    {
       public delegate void midelegate();
       public delegate void midelegate2( string mas );

       public Delegados()
        {
            midelegate d1 = new midelegate( MensajeBienvenida.saludo );
            d1();

            d1 = new midelegate( MensajeDespedida.saludo );
            d1();

            midelegate2 d2 = new midelegate2 ( MensajeDespedida.saludo2 );
            d2( "del agua" );
        }
    }

    //-----------------------------------------------

    public class MensajeBienvenida
    {
        public static void saludo()
        {
            Console.WriteLine("hola perro");
        }
    }

    //----------------------------------------------- 

    public class MensajeDespedida
    {
        public static void saludo()
        {
            Console.WriteLine("adios perro");
        }

        public static void saludo2( string extra )
        {
            Console.WriteLine("adios perro {0}", extra );
        }
    }
}
