using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class ExprecionesRegulares
    {
        string frase = "mi nombre es erick y mi #de telefono es (+52)6672-238-086 (+44)123-45-67 y mi codigo postal es 296779";
        string patron = "[mi]";
        string patron2 = @"\d{4}-\d{3}-\d{3}";
        //() para grupos 
        //erick? no grupos busca una o cero concidencia "k"
        public ExprecionesRegulares()
        {
            Regex regex = new Regex(patron);
            MatchCollection match = regex.Matches( frase );

            if (match.Count > 0) Console.WriteLine($"se a encontrado [mi] { match.Count }");
            else Console.WriteLine("no se a enciontrado [mi]");

            MatchCollection match2 = new Regex(patron2).Matches( frase );
            if(match2.Count > 0) Console.WriteLine($"se a encontrado nunero de telefono {match.Count}");
            else Console.WriteLine("no se a enciontrado # de telefono");
        }
    }
}
