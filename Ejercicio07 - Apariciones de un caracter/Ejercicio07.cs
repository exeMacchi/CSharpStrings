using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio07___Apariciones_de_un_caracter
{
    class Ejercicio07
    {
        static void Main()
        {
            /* 
                7. Escriba un programa que pida un texto y luego un carácter (ambos por 
                   teclado), e indicar la cantidad de veces que aparece en el texto. 
            */

            string texto = PedirTexto();
            char letra = PedirLetra();
            int contadorLetra = BuscarLetraEnElTexto(texto, letra);

            MostrarResultado(contadorLetra, letra);
        }

        static string PedirTexto()
        {
            Console.Write("Ingrese un pequeño texto: ");
            return Console.ReadLine();
        }

        static char PedirLetra()
        {
            Console.Write("Ingrese una letra: ");
            return Convert.ToChar(Console.Read());
        }

        static int BuscarLetraEnElTexto(string texto, char letra)
        {
            int contadorLetra = 0;

            for (int i = 0; i < texto.Length; i++)
            {
                if (texto[i] == Char.ToUpper(letra) || texto[i] == Char.ToLower(letra))
                {
                    contadorLetra++;
                }
            }

            return contadorLetra;
        } 

        static void MostrarResultado(int contadorLetra, char letra)
        {
            if (contadorLetra != 0)
            {
                Console.WriteLine($"La letra {letra} aparece {contadorLetra} " +
                                  $"veces en el texto.");
            }
            else
            {
                Console.WriteLine($"La letra {letra} no aparece en el texto.");
            }
        }
    }
}
