using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio08___Insercion_de_un_caracter
{
    class Program
    {
        static void Main()
        {
            /* 
                8. Escriba un programa que pida por el teclado una cadena, un carácter y 
                   una posición (número). El programa deberá insertar el carácter 
                   ingresado dentro de la cadena en la posición indicada. El programa
                   deberá manejar condiciones de error (ejemplo: si la posición ingresada 
                   supera el largo de la cadena).
            */

            /* 
                Método sencillo 
                string texto = Console.ReadLine();
                char caracter = Convert.ToChar(Console.ReadLine());
                int posicion = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine($"Texto nuevo: " +
                                  $"{texto.Insert(posicion, caracter.ToString())}");
            */

            // Método manual 
            string texto = PedirTexto();
            char caracter = PedirCaracter();
            // Al usuario le pido la posición, no el índice.
            int indice = PedirPosicion(texto.Length) - 1;
            string nuevoTexto = InsertarCaracter(indice, texto, caracter);

            Console.WriteLine($"Nuevo texto: {nuevoTexto}");
        }

        static string PedirTexto()
        {
            Console.Write("Ingrese un pequeño texto: ");
            return Console.ReadLine();
        }

        static char PedirCaracter()
        {
            Console.Write("Ingrese un caracter: ");
            return Convert.ToChar(Console.ReadLine());
        }

        static int PedirPosicion(int longitudTexto)
        {
            int posicion = 0;
            do
            {
                Console.Write("Ingrese la posición donde quiera insertar el caracter: ");
                posicion = Convert.ToInt32((Console.ReadLine()));

                // Al usuario le doy la posibilidad de agregar un caracter al
                // al final del texto.
                if (posicion > longitudTexto + 1 || posicion == 0)
                {
                    Console.WriteLine("Error: posición fuera de rango.");
                }

            } while (posicion > longitudTexto + 1);

            return posicion;
        }

        static string InsertarCaracter(int indice, string texto, char caracter)
        {
            char[] nuevaCadena = new char[texto.Length + 1];

            if (indice < texto.Length)
            {
                CaracterDentroDeCadena(nuevaCadena, texto, indice, caracter);
            }
            else
            {
                CopiarCadena(nuevaCadena, texto);
                nuevaCadena[texto.Length] = caracter;
            }

            return new string(nuevaCadena);
        }

        static void CopiarCadena(char[] nueva, string texto)
        {
            for (int i = 0; i < texto.Length; i++)
            {
                nueva[i] = texto[i];
            }
        }

        static void CaracterDentroDeCadena(char[] nuevaCadena, string texto, int indice, 
                                           char caracter)
        {
            bool agregado = false;
            for (int i = 0; i < texto.Length; i++)
            {
                if (i == indice || agregado)
                {
                    if (!agregado)
                    {
                        nuevaCadena[i] = caracter;
                        agregado = true;
                        i--;
                    }
                    else
                    {
                        nuevaCadena[i + 1] = texto[i];
                    }
                }
                else
                {
                    nuevaCadena[i] = texto[i];
                }
            }
        }
    }
}
