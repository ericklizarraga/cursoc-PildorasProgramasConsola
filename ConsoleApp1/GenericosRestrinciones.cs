using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntroCShark
{
    public class GenericosRestrinciones
    {
        public GenericosRestrinciones()
        {
            Console.WriteLine("Genericos Restriciones");

            AlmacenaEmpleados<Director> empleado = new AlmacenaEmpleados<Director>( 2 );
            empleado.insertEmpleado(new Director(2500));
            empleado.insertEmpleado(new Director(3500));
            Console.WriteLine($"Director 1 salario {empleado.getEmpleados(1).getSalario()}");

            //AlmacenaEmpleados<String> empleado2 = new AlmacenaEmpleados<String>(2);
        }
    }
    //_-----------------------------
    class AlmacenaEmpleados<T> where T : IParaEmpleados
    {
        private int i = 0;
        private T[] arreglo;

        public AlmacenaEmpleados( int length)
        {
            this.arreglo = new T[ length ];
        }

        public void insertEmpleado( T element )
        {
            if( this.i < this.arreglo.Length)
            {
                this.arreglo[i] = element;
                this.i++;
            }
            else
            {
                Console.WriteLine("arreglo empleados lleno");
            }
        }


        public T getEmpleados(int indice)
        {
            return this.arreglo[indice];
        }
    }
    //_-----------------------------
    interface IParaEmpleados
    {
        double getSalario();
    }
    //_-----------------------------
    class Secretaria : IParaEmpleados
    {
        private double Salario;

        public Secretaria( double salario)
        {
            this.Salario = salario;
        }

        public double getSalario()
        {
            return this.Salario;
        }
    }
    //_-----------------------------
    class Director : IParaEmpleados
    {
        private double Salario;

        public Director(double salario)
        {
            this.Salario = salario;
        }

        public double getSalario()
        {
            return this.Salario;
        }
    }
}
