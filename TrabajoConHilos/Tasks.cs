using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabajoConHilos
{
    internal class Tasks
    {
        public Tasks()
        {
            Task task = new Task(EjecutarTarea);
            task.Start();
            
            
            Task task2 = new Task(() =>
            {
                for(int j = 1; j <= 100; j++)
                {

                    var mithread = Thread.CurrentThread.ManagedThreadId;
                    Thread.Sleep(1000);

                    Console.WriteLine($"Tarea correspondiente al hilo:{mithread} desde el main");
                }
            });
            task2.Start();


            Console.ReadLine();
        }

        static void EjecutarTarea()
        {
            for(int i= 1; i <= 100; i++)
            {
                var mithread = Thread.CurrentThread.ManagedThreadId;
                Thread.Sleep(1000);

                Console.WriteLine($"esta es la vuelta de Thread es de:{mithread}");
            }
        }
    }
}
