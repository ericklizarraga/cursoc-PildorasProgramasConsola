
        
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabajoConHilos
    {
        internal class TaskParalelas
        {
            public static int acumulador = 0;

            public TaskParalelas()
        {
            //   for(int i = 0; i < 100; i++)
            //   {
            //        RealizarTarea(i);
            //        Console.WriteLine($" Acumulador vale {acumulador}. tarea realizada poor el hilo {Thread.CurrentThread.ManagedThreadId}");

            //   }

            Parallel.For(0,100, RealizarTarea);

        }

            static void RealizarTarea( int dato) 
            {
               if( ( acumulador % 2) == 0)
                {
                    acumulador += dato;
                    Thread.Sleep(100);
                }
                else
                {
                    acumulador -= dato;
                    Thread.Sleep(100);
                }
                Console.WriteLine($" Acumulador vale {acumulador}. tarea realizada poor el hilo {Thread.CurrentThread.ManagedThreadId}");
            }

        }
    }
