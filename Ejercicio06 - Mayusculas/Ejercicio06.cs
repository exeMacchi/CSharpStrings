using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio06___Mayusculas
{
    class Ejercicio06
    {
        static void Main()
        {
            /* 
                6. Escriba un programa que pida una cadena por el teclado y la imprima 
                   después de convertirla toda a mayúscula.
            */

            /*  
                Método «sencillo»
                    Console.Write("Ingrese un par de palabras: ");
                    string palabra = Console.ReadLine();
                    Console.WriteLine(palabra.ToUpper());
            */

            // Método manual (ayuda StringBuilder)

            StringBuilder palabras = new StringBuilder(PedirPalabras());

            CorroborarPalabras(palabras);
            MostrarResultado(palabras);
        }

        static string PedirPalabras()
        {
            Console.Write("Ingrese un par de palabras: ");
            return Console.ReadLine();
        }

        static void CorroborarPalabras(StringBuilder palabras)
        {
            for (int i = 0; i < palabras.Length; i++)
            {
                palabras[i] = CorroborarCaracteres(palabras[i]);
            }
        }

        static char CorroborarCaracteres(char c)
        {
            switch (c)
            {
                case 'a': return 'A'; 
                case 'b': return 'B'; 
                case 'c': return 'C'; 
                case 'd': return 'D'; 
                case 'e': return 'E'; 
                case 'f': return 'F'; 
                case 'g': return 'G'; 
                case 'h': return 'H'; 
                case 'i': return 'I'; 
                case 'j': return 'J'; 
                case 'k': return 'K'; 
                case 'l': return 'L'; 
                case 'm': return 'M'; 
                case 'n': return 'N'; 
                case 'o': return 'O'; 
                case 'p': return 'P'; 
                case 'q': return 'Q'; 
                case 'r': return 'R'; 
                case 's': return 'S'; 
                case 't': return 'T'; 
                case 'u': return 'U'; 
                case 'v': return 'V'; 
                case 'w': return 'W'; 
                case 'x': return 'X'; 
                case 'y': return 'Y'; 
                case 'z': return 'Z';
                default: return c;
            }
        }

        static void MostrarResultado(StringBuilder palabras)
        {
            Console.WriteLine();
            Console.WriteLine(palabras.ToString());
            Console.WriteLine();
        } 
        
    }
}
