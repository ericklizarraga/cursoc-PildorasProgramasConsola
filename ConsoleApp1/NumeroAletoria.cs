using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

///---------- using static System.Math; //para poder los metodos y todas las cosas static sin need de poner Math.pow(); solo Pow(); 
///
namespace IntroCShark
{
    public class NumeroAletoria
    {
        public void numeroRamdom()
        {
            int num1, intentos = 1;
            
            Random random = new Random();
            int numRandom = random.Next(0, 100);

            Console.WriteLine("introduce un numero entero entre 0 / 100");
            num1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("" + numRandom);

            while (num1 != numRandom)
            {
                if (num1 > numRandom) Console.WriteLine($" es menor que {num1}");
                else Console.WriteLine($"es mayor que {num1}");

                num1 = int.Parse(Console.ReadLine());
                intentos++;
            }

            Console.WriteLine("le atinaste urra");
            Console.WriteLine($"intentos { intentos }");
        
        }
    }
}
