
using System.Threading;


//Func<bool> funcionSAludo = () =>
//{
//    Console.WriteLine("Hello, World!1 (hilo 2)");
//    Thread.Sleep(500);
//    Console.WriteLine("Hello, World!2 (hilo 2)");
//    Thread.Sleep(500);
//    Console.WriteLine("Hello, World!3 (hilo 2)");
//    Thread.Sleep(500);
//    Console.WriteLine("Hello, World!4 (hilo 2)");
//    Thread.Sleep(500);
//    Console.WriteLine("Hello, World!5 (hilo 2)");
//    return true;
//};


//Func<bool> func = () => {

//    Console.WriteLine("Hello, World!1 (hilo 1)");
//    Thread.Sleep(500);
//    Console.WriteLine("Hello, World!2 (hilo 1)");
//    Thread.Sleep(500);
//    Console.WriteLine("Hello, World!3 (hilo 1)");
//    Thread.Sleep(500);
//    Console.WriteLine("Hello, World!4 (hilo 1)");
//    Thread.Sleep(500);
//    Console.WriteLine("Hello, World!5 (hilo 1)");

//    funcionSAludo();

//    return true;

//};

//func();

namespace TrabajoConHilos
{
    class Program
    {
        static void Main(string[] args) {
            //new SincronizarHilos();

            //new BloqueoDeHilo();

            //new HilosTareasCompletadas();

            //new PoolThread();

            //new Tasks();

            //new TaskConsecutivas();

            //new TaskPrioridad();

            //new TaskParalelas();

            new CancelarTask();
        }
 
    }
}