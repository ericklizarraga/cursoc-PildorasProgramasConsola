using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabajoConHilos
{
    internal class CancelarTask
    {
        public static int acumulador = 0;

        public CancelarTask()
        {
            CancellationTokenSource miToken = new CancellationTokenSource();
            CancellationToken cancellationToken = miToken.Token;

            Task.Run(() => RealizarTarea(cancellationToken));

            for (int i = 0; i < 100; i++)
            {
                acumulador += 30;
                Thread.Sleep(1000);

                if (acumulador > 100)
                {
                    miToken.Cancel();
                    break;
                }
            }
            Thread.Sleep(1000);

            Console.WriteLine($"acumulador final {acumulador}");
            Console.ReadLine();
        }

        static void RealizarTarea(CancellationToken  token)
        {

            for (int i = 0; i< 100;i++)
            {
                acumulador++;
                var miThread =  Thread.CurrentThread.ManagedThreadId;
                Thread.Sleep(1000);
                Console.WriteLine($" Acumulador vale {acumulador}. tarea realizada poor el hilo {Thread.CurrentThread.ManagedThreadId}");

                if(token.IsCancellationRequested)
                {
                    acumulador = 0;
                    return;
                }
            }
        }

    }
}
