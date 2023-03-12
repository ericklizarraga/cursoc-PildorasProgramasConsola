using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabajoConHilos
{
    internal class TaskConsecutivas
    {
        public TaskConsecutivas()
        {

            Task task = Task.Run(() => EjecutarTarea() );


            Task task2 = task.ContinueWith(EjecutarOtraTarea);


            Console.ReadLine();
        }

        static void EjecutarTarea()
        {
            for (int i = 1; i <= 10; i++)
            {
                var mithread = Thread.CurrentThread.ManagedThreadId;
                Thread.Sleep(1000);

                Console.WriteLine($"esta es la vuelta de Thread es de:{mithread}");
            }
        }
        
        
        static void EjecutarOtraTarea( Task obj)
        {
            for (int i = 1; i <= 10; i++)
            {
                var mithread = Thread.CurrentThread.ManagedThreadId;
                Thread.Sleep(1000);

                Console.WriteLine($"esta es otra tarea y  la vuelta de Thread es de:{mithread}");
            }
        }
    }
}
