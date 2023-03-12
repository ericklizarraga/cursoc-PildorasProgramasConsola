using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntroCShark
{
    public enum Emunumerados
    {
        LUNES,
        MARTES,
        MIERCOLES,
        JUEVES,
        VIERNES,
        SABADO,
        DOMINGO
    }

    public enum Bonos
    {
        bajo = 500,
        normal = 1000,
        bueno = 1500,
        extra = 2000
    }

    public class Empleado
    {
        private double salario, bonus;

        public Empleado( Bonos bonusEmpleado, double salario)
        {
            this.bonus = (double)bonusEmpleado;
            this.salario = salario + this.bonus;
        } 

        public double Salario { get => this.salario; }
    }
}
