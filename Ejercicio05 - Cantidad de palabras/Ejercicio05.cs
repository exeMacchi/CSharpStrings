using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio05___Cantidad_de_palabras
{
    class Ejercicio05
    {
        static void Main()
        {
            /* 
                5. Escriba un programa que pida el ingreso de un texto por teclado e 
                   indique la cantidad de palabras que posee. 
            */

            string texto;
            int palabras;

            PedirTexto(out texto);
            palabras = ContarPalabras(texto);
            MostrarResultado(palabras);
        }

        static void PedirTexto(out string texto)
        {
            Console.Write("Ingrese un pequeño texto: ");
            texto = Console.ReadLine();
        }

        static int ContarPalabras(string texto)
        {
            string[] palabras = texto.Split();
            int erroresOrtograficos = CorroborarPalabras(palabras); 
            return palabras.Length - erroresOrtograficos;
        }

        static int CorroborarPalabras(string[] palabras)
        {
            int e = 0;

            for (int i = 0; i < palabras.Length; i++)
            {
                if (palabras[i] == "." || palabras[i] == ",")
                {
                    e++;
                }
            }

            return e;
        }

        static void MostrarResultado(int cantPalabras)
        {
            Console.WriteLine($"El texto tiene {cantPalabras} palabras.");
        }
    }
}
