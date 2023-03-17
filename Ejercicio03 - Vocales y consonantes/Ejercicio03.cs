using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio03___Vocales_y_consonantes
{
    class Ejercicio03
    {
        static void Main()
        {
            /* 
                3. Escriba un programa que pida el ingreso de un texto por teclado e 
                   indique cuántas vocales y cuántas consonantes tiene. 
            */

            string texto;
            int contadorVocales = 0;
            int contadorConsonantes = 0;

            PedirTexto(out texto);
            VerificarTexto(texto, ref contadorVocales, ref contadorConsonantes);
            MostrarResultados(contadorVocales, contadorConsonantes);
        }

        static void PedirTexto(out string texto)
        {
            Console.Write("Ingrese un pequeño texto: ");
                texto = Console.ReadLine();
        }

        static void VerificarTexto(string texto, ref int contadorVocales, 
                                   ref int contadorConsonantes)
        {
            for (int i = 0; i < texto.Length; i++)
            {
                if (texto[i] != ',' && texto[i] != '.' && texto[i] != ' ')
                {
                    switch (texto[i])
                    {
                        case 'a': case 'A':  
                        case 'e': case 'E': 
                        case 'i': case 'I':  
                        case 'o': case 'O': 
                        case 'u': case 'U':
                            contadorVocales++;
                            break;

                        default: contadorConsonantes++; break;
                    }
                }
            }
        }

        static void MostrarResultados(int contadorVocales, int contadorConsonantes)
        {
            Console.WriteLine();
            Console.WriteLine($"La palabra tiene {contadorVocales} vocales y " +
                              $"{contadorConsonantes} consonantes.");
        }
    }
}
