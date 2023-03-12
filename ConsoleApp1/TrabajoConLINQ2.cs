using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class TrabajoConLINQ2
    {
        public TrabajoConLINQ2()
        {
            new ControlEnterpriseEmpleado();
        }
    }

    //-----------------------------------------------

    class ControlEnterpriseEmpleado
    {
        public List<Empresa> listEmpresa = new List<Empresa>();
        public List<Empleado> listEmpleado = new List<Empleado>();


        public ControlEnterpriseEmpleado()
        {
            listEmpresa.AddRange( new Empresa[]
            {
                new Empresa(){ Id=1, Name ="google" },
                new Empresa(){ Id=2, Name ="apple" },
                new Empresa(){ Id=3, Name ="facebook" }
            });

            listEmpleado.AddRange( new Empleado[]
            {
                new Empleado(){ Id=01,Name="erick",Stand="ceo",Salary=10000,IdEnterprise= 1 },
                new Empleado(){ Id=01,Name="pedro",Stand="ceo",Salary=13000,IdEnterprise= 2 },
                new Empleado(){ Id=01,Name="sebastian",Stand="ceo",Salary=10900,IdEnterprise= 3 },
                new Empleado(){ Id=01,Name="enrique",Stand="director",Salary=90000,IdEnterprise= 1 },
                new Empleado(){ Id=01,Name="ismael",Stand="director",Salary=8000,IdEnterprise= 3 },
            });
            Console.WriteLine("-----------------getempleadosCeo-------------------");
            getCeo();
            Console.WriteLine("-----------------getempleadosOrdenados-------------------");
            getempleadosOrdenados();
            Console.WriteLine("------------getEmpledosgoogle-----------------------");
            getEmpledosPildoras();
        }

        public void getCeo()
        {
            IEnumerable<Empleado> ceos = from empledo in listEmpleado where empledo.Stand == "ceo" select empledo;

            foreach ( Empleado empleado in ceos )
            {
                empleado.getDataEnterprise();
            }
        }


        public void getempleadosOrdenados()
        {
            IEnumerable<Empleado> empleadosOrdenadosByName = from empleado in listEmpleado orderby empleado.Name descending select empleado;
            foreach( Empleado empleado in empleadosOrdenadosByName)
            {
                empleado.getDataEnterprise();
            }
        }

        public void getEmpledosPildoras()
        {
            IEnumerable<Empleado> empleados = from empleado in listEmpleado join empresa in listEmpresa
                                              on empleado.IdEnterprise equals empresa.Id
                                              where empresa.Name == "google"
                                              select empleado;
            foreach(Empleado empleado in empleados)
            {
                empleado.getDataEnterprise();
            }
        } 
    }

    //-----------------------------------------------

    class Empresa
    {
       public int Id { get; set; }
       public string Name { get; set; }

        public void getDataEnterprise()
        {
            Console.WriteLine($" Enterprise :{ Name }, Id : { Id }");
        }
    }


    //-----------------------------------------------

    class Empleado
    {
       public int Id { get; set; }
       public string Name { get; set; }
       public double Salary  { get; set; }
       public string Stand { get; set; }
       public int IdEnterprise { get; set; }

        public void getDataEnterprise()
        {
            Console.WriteLine($" Name :{ Name }, Id : { Id } , Stand: { Stand } , Salary : { Salary } , IdEnterprise : { IdEnterprise} ");
        }
    }
}
