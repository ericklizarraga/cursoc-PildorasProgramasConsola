using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class FuncionesLamda
    {

        public delegate int Operacion(int num);
        Operacion operacion = new Operacion(( num ) => 1);

        public delegate string Saludo();
        Saludo saludo = new Saludo(() => "Hola Mundo");

        //-------------------------------

        public FuncionesLamda(){

            Console.WriteLine(saludo()+": desde una funcion lamda");

            List<int> list = new List<int>() { 1,2,3,4,5,6,7,8,9,10 };
            List<int> numerosPares =  list.FindAll( x => x % 2 == 0 ); 

            numerosPares.ForEach( x => Console.WriteLine( x ) );
        }
    }
}
