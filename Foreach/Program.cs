using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Foreach
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string[] Nombres = { "gikbert", "jorge", "juno", "Karina", "noelia" };
            string[] Apellidos = { "Vargas", "Lara", "Ramirez", "fernandez", "Rodriguez" };

            foreach (string Usuario in Nombres)
        
            {
                Console.WriteLine("El nombre es: " + Usuario);
            }

            {
                Console.WriteLine("El apellido es: " + Apellidos);
            }
            
            Console.ReadKey();
        }

    }
}
