
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntroCShark
{
    public class Excepciones
    {
        public void numeroRamdom()
        {
            int num1, intentos = 1;

            Random random = new Random();
            int numRandom = random.Next(0, 100);

            repeat:
            Console.WriteLine("introduce un numero entero entre 0 / 100");

            try
            {
                num1 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("" + numRandom);

                while (num1 != numRandom)
                {
                    if (num1 > numRandom) Console.WriteLine($" es menor que {num1}");
                    else Console.WriteLine($"es mayor que {num1}");

                    num1 = int.Parse(Console.ReadLine());
                    intentos++;
                }

            }
            catch (Exception ex) when ( ex.GetType() != typeof(FormatException) ) 
            {
                intentos++;
                Console.WriteLine(ex.Message);
                goto repeat;
            }
            catch (FormatException ex)
            {
                intentos++;
                Console.WriteLine("has introducido texto");
                Console.WriteLine(ex.Message);
                goto repeat;
            }
            finally 
            {
                Console.WriteLine("fin programa");
            }
            //catch (FormatException ex)
            //{
            //    intentos++;
            //    Console.WriteLine("has introducido texto");
            //    Console.WriteLine(ex.Message);
            //    goto repeat;
            //}
            //catch ( Exception error)
            //{
            //    intentos++;
            //    Console.WriteLine($">{error.Message}");
            //    goto repeat;
            //}

             
            Console.WriteLine("le atinaste urra");
            Console.WriteLine($"intentos { intentos }");

        }
    }
}
