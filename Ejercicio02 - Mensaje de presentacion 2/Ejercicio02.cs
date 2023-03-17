using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio02___Mensaje_de_presentacion_2
{
    class Ejercicio02
    {
        static void Main()
        {
            /* 
                2. Repita el ejercicio anterior pero que ahora también se pida el sexo 
                   (M/m/F/f). El programa debe saludarlo anteponiendo «Sr.» o «Sra.». 
                   Es decir «Bienvenido Sr.... o Bienvenido Sra….». 
            */

            string nombre, apellido; 
            char genero;

            PedirInformacion(out nombre, out apellido, out genero);
            SaludarUsuario(nombre, apellido, genero);
        }

        static void PedirInformacion(out string nombre, out string apellido, 
                                     out char genero)
        {
            Console.WriteLine("¡Bienvenido! ¿Cómo es tu nombre?");
            Console.Write("Nombre/s: ");
                nombre = Console.ReadLine();
            Console.Write("Apellido/s: ");
                apellido = Console.ReadLine();
            Console.Write("¿Cuál es tu género? (M / F): ");
                genero = Convert.ToChar(Console.Read()); 
        }

        static void SaludarUsuario(string nombre, string apellido, char genero)
        {
            if (genero == 'M' || genero == 'm')
            {
                Console.WriteLine();
                Console.WriteLine($"Bienvenido, Sr. {nombre} {apellido}");
            }
            else
            {
                Console.WriteLine();
                Console.WriteLine($"Bienvenida, Sra. {nombre} {apellido}");
                Console.WriteLine();
            }
        }
    }
}
