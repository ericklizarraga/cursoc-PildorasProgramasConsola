using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class DelegadoPredicado
    {
        public DelegadoPredicado()
        {

            List<int> listaNumeros = new List<int>();
            
            listaNumeros.AddRange( new int[] { 1,2,3,4,5,6,7,8,8,10 } );

            Predicate<int> elDelegadopredicado = new Predicate<int>( DamePares );//--

            List<int> numPares = listaNumeros.FindAll( elDelegadopredicado );
            foreach( int num in numPares)
            {
                Console.WriteLine( num );
            }


            ///--------------------------------------
            ///

            List<Persona> personaList = new List<Persona>();
            
            personaList.AddRange( new Persona[] {
                new Persona{ Nombre="erick", Edad=27},
                new Persona{ Nombre="pedro", Edad=25},
                new Persona{ Nombre="enrique", Edad=22},
                new Persona{ Nombre="scarlet", Edad=4},
                new Persona{ Nombre="fany", Edad=6},
            });

            Predicate<Persona> predicatePersona = new Predicate<Persona>( EsMayorEdad );//--

            List<Persona> personasMayores = personaList.FindAll( predicatePersona );
            personasMayores.ForEach( ( Persona p ) =>
            {
                Console.WriteLine( "Nombre: {0}",p.Nombre );
            });

            //----------------------

            var existeErick =  personasMayores.Exists( ( Persona p ) => {
                if(p.Nombre == "erick") return true;
                return false;
            });

            if (existeErick) Console.WriteLine($"si existe el erick");
            else Console.WriteLine($"no existe el erick");

        }

        public static bool DamePares( int num)
        {
            if( num % 2 == 0 ) return true;

            return false;
        }


        public static bool EsMayorEdad( Persona persona)
        {
            if (persona.Edad >= 18) return true;
            return false;
        }
    }



    public class Persona
    {
        public string Nombre { get; set; }
        public int Edad { get; set; } 
    }

}
