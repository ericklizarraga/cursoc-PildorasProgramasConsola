using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabajoConHilos
{
    internal class PoolThread
    {
        public PoolThread()
        {
            for (int i = 1; i <= 100; i++)
            {
                //Thread t = new Thread(PoolThread.EjecutarTarea);
                //t.Start();

                ThreadPool.QueueUserWorkItem(EjecutarTarea,i);
            }

            Console.ReadLine();
        }

        static void EjecutarTarea( object o)
        {
            int tarea = (int)o;
            Console.WriteLine($"Thread N#:{ Thread.CurrentThread.ManagedThreadId} ha comenzado al tarea n#:{tarea}");
            Thread.Sleep(1000);
            Console.WriteLine($"Thread N#:{ Thread.CurrentThread.ManagedThreadId} ha terminado al tarea n#:{tarea}");
        }
    }
}
