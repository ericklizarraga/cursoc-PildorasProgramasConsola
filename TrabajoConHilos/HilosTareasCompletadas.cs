using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabajoConHilos
{
    internal class HilosTareasCompletadas
    {
        public HilosTareasCompletadas()
        {

            var tareaTerminada = new TaskCompletionSource<bool>();

            Thread hilo1 = new Thread(() =>
            {
               for(int i = 0; i< 5; i++)
                {
                    Console.WriteLine("hilo 1");
                    Thread.Sleep(1000);
                }
               tareaTerminada.SetResult(true);
            });

           
            Thread hilo2 = new Thread(() =>
            {
               for(int i = 0; i< 5; i++)
                {
                    Console.WriteLine("hilo 2");
                    Thread.Sleep(1000);
                }
            });
            
            Thread hilo3 = new Thread(() =>
            {
               for(int i = 0; i< 5; i++)
                {
                    Console.WriteLine("hilo 3");
                    Thread.Sleep(1000);
                }
            });

            hilo1.Start();

            var resutado = tareaTerminada.Task.Result;

            hilo2.Start();

            hilo3.Start();
        }
    }
}