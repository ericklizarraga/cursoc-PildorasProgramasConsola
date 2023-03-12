using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabajoConHilos
{
    internal class SincronizarHilos
    {
        public SincronizarHilos()
        {
            Thread t = new Thread(this.MetodoSaludo);
            t.Start();
            t.Join();

            Thread t2 = new Thread(this.MetodoSaludo);
            t2.Start();
            t2.Join();

            Thread.Sleep(500);
            Console.WriteLine("Hello, World!1 (hilo 1)");
            Thread.Sleep(500);
            Console.WriteLine("Hello, World!1 (hilo 1)");
            Thread.Sleep(500);
            Console.WriteLine("Hello, World!1 (hilo 1)");
            Thread.Sleep(500);
            Console.WriteLine("Hello, World!1 (hilo 1)");
        }

        public void MetodoSaludo()
        {
            Console.WriteLine("Hello, World!2 (hilo 2)");
            Thread.Sleep(500);
            Console.WriteLine("Hello, World!2 (hilo 2)");
            Thread.Sleep(500);
            Console.WriteLine("Hello, World!2 (hilo 2)");
            Thread.Sleep(500);
            Console.WriteLine("Hello, World!2 (hilo 2)");

        }
    }
}
