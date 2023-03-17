using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio01___Mensaje_de_presentacion_1
{
    class Ejercicio01
    {
        static void Main()
        {
            /* 
                1. Escriba un programa que imprima un mensaje de presentación, pregunte 
                   cómo se llama el usuario (nombre y apellido) y lo salude. 
                   Ejemplo: «Bienvenido Lionel Messi a nuestra casa». 
            */

            string nombre, apellido;

            PedirNombre(out nombre, out apellido);
            SaludarUsuario(nombre, apellido);
        }

        static void PedirNombre(out string nombre, out string apellido)
        {
            Console.WriteLine("¡Bienvenido! ¿Cómo es tu nombre?");
            Console.Write("Nombre/s: ");
                nombre = Console.ReadLine();
            Console.Write("Apellido/s: ");
                apellido = Console.ReadLine();
        }

        static void SaludarUsuario(string nombre, string apellido)
        {
            Console.WriteLine();
            Console.WriteLine($"Bienvenido, {nombre} {apellido}, a nuestra casa!");
            Console.WriteLine();
        }
    }
}
