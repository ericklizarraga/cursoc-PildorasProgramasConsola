using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class TrabajoConLINQ
    {
        public static int[] arrayNumbers = new int[] { 1 ,2, 3,4,5,6,7,8,9,10 };

        public TrabajoConLINQ()
        {
            NumerosPares();
        }

        public static void NumerosPares()
        {
            List<int> numerosPares = new List<int>();

            foreach (int i in arrayNumbers)
            {
                if(i%2==0) numerosPares.Add(i);
            }

            foreach (int i in numerosPares)
            {
                Console.WriteLine(i);
            }
        }

        public static void NumerosParesLINQ()
        {
            IEnumerable<int> numerosPares = from numero in arrayNumbers where numero%2==0 select numero;

            foreach (int i in numerosPares)
            {
                Console.WriteLine(i);
            }
        }
    }
}
