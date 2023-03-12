using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntroCShark
{
    public class UsoCheked
    {
        public void Index()
        {
            int numero = int.MaxValue;

            checked
            {
                int resul = numero + 1;
                Console.WriteLine(resul);
                // solo fuciona con losnuemros enteros
            }
        }
    }
}
