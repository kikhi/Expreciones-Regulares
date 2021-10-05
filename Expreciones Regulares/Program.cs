using System;
using System.Text.RegularExpressions;

namespace Expreciones_Regulares
{
    /*  Evaluar si una variable es un texto, un numero, un correo o una URL
    *  para guia de los metacaracteres checar:
    https://www.ibm.com/docs/es/netcoolomnibus/8.1?topic=SSSHTQ_8.1.0/com.ibm.netcool_OMNIbus.doc_8.1.0/omnibus/wip/common/reference/omn_ref_re_metacharacters.html */

    internal class Program
    {
        static void Main(string[] args)
        {
            /*  Metacaracteres  */
            Console.Title = "Expreciones irregulares";
            var x = "";
            bool menu = true;

            while (menu == true)
            {
                Console.Write("Introduce para analisar: ");
                x = Console.ReadLine();
                Metacaracteres(x);
                Console.ReadKey();
                Console.Clear();
            }
        }
        private static void Metacaracteres(string x)
        {
            Regex numero = new Regex(@"^\d");
            Regex variable = new Regex(@"[a-zA-Z0-9_]{1,10}");
            Regex correo = new Regex(@"^[a-zA-Z]+@[a-zA-Z]+\.[a-zA-Z]{2,3}$");
            Regex url = new Regex(@"^w{3}\.[a-zA-Z]*\.com$");
            Regex num_decimal = new Regex(@"[0-9]{0,9}\.?[0-9]+([eE][-+]?[0-9]{1,9})?");

            if (numero.IsMatch(x))
            {
                Console.WriteLine("Es un numero");
            }
            else if (correo.IsMatch(x))
            {
                Console.WriteLine("Es un correo");
            }
            else if (url.IsMatch(x))
            {
                Console.WriteLine("Es un URL");
            }
            else if (variable.IsMatch(x))
            {
                Console.WriteLine("Es una variable");
            }
        }
    }
}
