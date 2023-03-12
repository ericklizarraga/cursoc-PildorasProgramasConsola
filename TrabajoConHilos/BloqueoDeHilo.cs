using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabajoConHilos
{
    internal class BloqueoDeHilo
    {
        public BloqueoDeHilo()
        {
            CuentaBancaria cuentaFamilia = new CuentaBancaria(2000);

            Thread[] hilosPersonas = new Thread[15];

            for( int i = 0;i < hilosPersonas.Length; i++)
            {
                Thread t = new Thread(cuentaFamilia.VamosRetirarEfectivo);
                t.Name = i.ToString();
                hilosPersonas[i] = t;
            }

            foreach (Thread hilo in hilosPersonas)
            {
                hilo.Start();
                hilo.Join();
            }

        }
    }

        //----------------------------------------

    class CuentaBancaria
    {
        private Object bloqueaSaldoPositivo = new Object();
        double Saldo { get; set; }

        public CuentaBancaria(double saldo)
        {
            Saldo = saldo;
        }


        public double RetirarEfectivo( double cantidad)
        {
            if ((Saldo - cantidad) < 0)
            {
                Console.WriteLine($"saldo insuficiente, queda ${Saldo} en la cuenta, hilo actual : {Thread.CurrentThread.Name}");
                return Saldo;
            }

            lock(bloqueaSaldoPositivo){
                if (Saldo >= cantidad)
                {
                    Console.WriteLine($" retiron {cantidad} y queda {(Saldo - cantidad)} de la cuenta hilo actual:{Thread.CurrentThread.Name}");
                    Saldo = Saldo - cantidad;
                }


                return Saldo;
            }
        }
        public void VamosRetirarEfectivo()
        {
            foreach (int i in new int[]{ 1,2,3,4 } )
            {
                Console.WriteLine($" esta sacando dinero el hilo: { Thread.CurrentThread.Name}");
                this.RetirarEfectivo(500);
            }
        }
    }
}
