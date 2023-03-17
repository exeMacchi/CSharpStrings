using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio04___Mayusculas_y_minusculas
{
    class Ejercicio04
    {
        static void Main()
        {
             /* 
                4. Escriba un programa que pida el ingreso de una palabra por teclado y 
                   la imprima después de convertir el primer carácter en mayúscula y el 
                   resto, en minúsculas. 
            */

            /* 
                Método «sencillo»
                
                Console.Write("Ingrese una palabra: );
                string palabra = Console.ReadLine();
                
                TextInfo texto = CultureInfo.CurrentCulture.TextInfo;
                Console.WriteLine(texto.ToTitleCase(palabra));
            */

            /*
               Método manual (con ayuda de la clase StringBuilder para realizar 
               modificaciones) 
            */

            StringBuilder palabra = new StringBuilder(PedirPalabra());
            VerificarPalabra(palabra);
            MostrarResultado(palabra);
        }

        static string PedirPalabra()
        {
            Console.Write("Ingrese una palabra: ");
            return Console.ReadLine();
        }

        static void VerificarPalabra(StringBuilder palabra)
        {
            for (int i = 0; i < palabra.Length; i++)
            {
                if (i == 0)
                {
                    palabra[i] = MinAMayus(palabra[i]);
                }
                else
                {
                    palabra[i] = MayusAMin(palabra[i]);
                }
            }
        }

        static char MinAMayus(char letraInicio)
        {
            switch (letraInicio)
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
                default: return letraInicio;
            }
        }

        static char MayusAMin(char c)
        {
            switch (c)
            {
                case 'A': return 'a';
                case 'B': return 'b'; 
                case 'C': return 'c'; 
                case 'D': return 'd';
                case 'E': return 'e';
                case 'F': return 'f'; 
                case 'G': return 'g';
                case 'H': return 'h';
                case 'I': return 'i';
                case 'J': return 'j'; 
                case 'K': return 'k'; 
                case 'L': return 'l'; 
                case 'M': return 'm'; 
                case 'N': return 'n'; 
                case 'O': return 'o'; 
                case 'P': return 'p'; 
                case 'Q': return 'q'; 
                case 'R': return 'r'; 
                case 'S': return 's'; 
                case 'T': return 't'; 
                case 'U': return 'u'; 
                case 'V': return 'v'; 
                case 'W': return 'w'; 
                case 'X': return 'x'; 
                case 'Y': return 'y'; 
                case 'Z': return 'z';
                default: return c;
            }
        }

        static void MostrarResultado(StringBuilder palabra)
        {
            Console.WriteLine();
            Console.WriteLine(palabra.ToString());
            Console.WriteLine();
        }
    }
}
