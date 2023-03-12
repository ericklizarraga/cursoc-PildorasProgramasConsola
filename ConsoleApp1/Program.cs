

using ConsoleApp1;

namespace IntroCShark
{
    public class Program
    {
        //el finally se utiliza para liberar recursos
        public static void Main(string[] args)
        {
            //NumeroAletoria numAleatorio = new NumeroAletoria();
            //numAleatorio.numeroRamdom();

            //-----------------------------------------------

            //Excepciones ex = new Excepciones();
            //ex.numeroRamdom();

            //-----------------------------------------------

            //UsoCheked usoCheked = new UsoCheked();
            //usoCheked.Index();

            //-----------------------------------------------

            //try
            //{
            //    string mes = LanzamientoDeExcepciones.NombreMes(13);
            //    Console.WriteLine(mes);
            //}
            //catch (Exception ex)
            //{
            //    Console.WriteLine($" error encontrado {ex.Message}");
            //}
            //-----------------------------------------------

            //EjemploFinally ejemploFinally = new EjemploFinally();

            //-----------------------------------------------

            //Emunumerados diasSemana = Emunumerados.LUNES;
            //Console.WriteLine( diasSemana.ToString() );
            //Emunumerados? emunumerados = null;

            //Bonos Antonio = Bonos.bueno;
            //Console.WriteLine(Antonio);
            //double valorBonoAntonio = (Double)Antonio;
            //Console.WriteLine( $"valor bonus {valorBonoAntonio}" );

            //Empleado empleado = new Empleado( Bonos.bajo, 3000);
            //Console.WriteLine($"bono {empleado.Salario}");

            //-----------------------------------------------

            //Generico<String> generio1 = new Generico<string>(4);
            //generio1.insertElement("hola");
            //generio1.insertElement("mundo");
            //generio1.insertElement("hello");
            //generio1.insertElement("world");
            //Console.WriteLine($"elemento en la poscicion 3: {generio1.getElemento(3)}");

            //Generico <Persona> generio2 = new Generico<Persona>(2);
            //generio2.insertElement(new Persona { nombre= "erick",apellido="lizarraga",edad="27" });
            //generio2.insertElement(new Persona { nombre= "Pedro",apellido="RAMOS",edad="22" });
            //Console.WriteLine($"elemento en la poscicion 1: {generio2.getElemento(1).nombre}");

            //-----------------------------------------------

            //new GenericosRestrinciones();

            //-----------------------------------------------

            //new Delegados();

            //-----------------------------------------------

            //new DelegadoPredicado();

            //-----------------------------------------------

            //new FuncionesLamda();

            //-----------------------------------------------

            //new ExprecionesRegulares();

            //-----------------------------------------------

            //new TrabajoConLINQ();   
            
            //-----------------------------------------------

            new TrabajoConLINQ2();  
            
         
        }
    }
}
