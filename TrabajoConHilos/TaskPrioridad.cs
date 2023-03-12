
        using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabajoConHilos
    {
        internal class TaskPrioridad
        {
            public TaskPrioridad()
            {
                RealizarTodasTareas();

                Console.ReadLine();
            }

            static void RealizarTodasTareas()
            {
                var tarea1 = Task.Run(() => EjecutarTarea1() );

                tarea1.Wait();

                var tarea2 = Task.Run(() => EjecutarTarea2() );

            //Task.WaitAll( tarea1, tarea2);                
            //Task.WaitAny(tarea1, tarea2);

            var tarea3 = Task.Run(() => EjecutarTarea3() );
            }
            

            static void EjecutarTarea1()
            {
                for (int i = 1; i <= 5; i++)
                {
                    var mithread = Thread.CurrentThread.ManagedThreadId;
                    Thread.Sleep(1000);

                    Console.WriteLine($"esta es la vuelta de Thread es de la tarea 1");
                }
            }
        
            static void EjecutarTarea2()
            {
                for (int i = 1; i <= 5; i++)
                {
                    var mithread = Thread.CurrentThread.ManagedThreadId;
                    Thread.Sleep(500);

                    Console.WriteLine($"esta es la vuelta de Thread es de la tarea 2");
                }
            }
        
            static void EjecutarTarea3()
            {
                for (int i = 1; i <= 5; i++)
                {
                    var mithread = Thread.CurrentThread.ManagedThreadId;
                    Thread.Sleep(500);

                    Console.WriteLine($"esta es la vuelta de Thread es de la tarea 3");
                }
            }
        }
    }

